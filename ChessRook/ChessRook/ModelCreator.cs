using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;
using Rook;

namespace KompasApi
{
    /// <summary>
    /// Создание модели ладьи 
    /// </summary>
    public class ModelCreator
    {
        /// <summary>
        /// Объект KompasConnector
        /// </summary>
        private KompasConnector _kompas;

        /// <summary>
        /// Объект Point
        /// </summary>
        private Point _point;

        /// <summary>
        /// Создание документа
        /// </summary>
        private void CreateDocument()
        {
            if (_kompas == null)
            {
                _kompas = new KompasConnector();
            }
            else
            {
                _kompas.OpenKompas3D();
            }
        }

        /// <summary>
        /// Отрисовка линии 
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        private void DrawLine(int x, int y)
        {
            _kompas.Document2D.ksLineSeg(_point.X, _point.Y, _point.X + x, _point.Y + y, 1);
            _point.X += x;
            _point.Y += y;
        }

        /// <summary>
        /// Создание модели ладьи
        /// </summary>
        /// <param name="rookInfo"> Объект класса RookInfo</param>
        public void CreateRook(RookInfo rookInfo)
        {
            CreateDocument();
            _point = new Point();
            CreateBase(rookInfo);
            CreateBattlement(rookInfo.UpperBaseHeight, rookInfo.UpperBaseDiameter,
                rookInfo.HasAnotherFeatures);
            _kompas.Document3D.drawMode = (int)ViewMode.vm_Shaded;
            _kompas.Document3D.shadedWireframe = true;
        }

        /// <summary>
        /// Создание основной части ладьи
        /// </summary>
        /// <param name="rookInfo"> Данные ладьи для построения </param>
        private void CreateBase(RookInfo rookInfo)
        {
            ksEntity plane = _kompas.Part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            ksEntity sketch = _kompas.Part.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDefinition = sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);

            sketch.Create();

            _kompas.Document2D = sketchDefinition.BeginEdit();

            DrawLine(rookInfo.UpperBaseDiameter / 2, 0);
            DrawLine(0, rookInfo.UpperBaseHeight);
            DrawLine(-rookInfo.UpperBaseDiameter / 10, 0);
            //диагональ
            var nextPoint = new Point()
            {
                X = 2 * rookInfo.LowerBaseDiameter / 5,
                Y = rookInfo.FullHeight - rookInfo.LowerBaseHeight - rookInfo.UpperBaseHeight,
            };
            var changePoint = new Point()
            {
                X = nextPoint.X - _point.X,
                Y = nextPoint.Y - _point.Y
            };

            DrawLine(changePoint.X, changePoint.Y);
            DrawLine(rookInfo.LowerBaseDiameter / 10, 0);
            DrawLine(0, rookInfo.LowerBaseHeight);
            DrawLine(-rookInfo.LowerBaseDiameter / 2, 0);

            //ось вращения, 3 - тип линии
            _kompas.Document2D.ksLineSeg(0, 0, 0, rookInfo.FullHeight, 3);

            sketchDefinition.EndEdit();

            Rotate(sketch);


            if (rookInfo.HasNewFeatures)
            {
                var baseSketch = CreateSketch(Obj3dType.o3d_planeXOZ,
                CreateOffsetPlane(Obj3dType.o3d_planeXOZ,
                -(rookInfo.FullHeight - rookInfo.UpperBaseHeight)));
                _kompas.Document2D = (ksDocument2D)baseSketch.BeginEdit();

                _kompas.Document2D.ksRectangle(DrawRectangle(-rookInfo.LowerBaseDiameter / 2,
                    -rookInfo.LowerBaseDiameter / 2, (rookInfo.LowerBaseDiameter / 2) * 2,
                    (rookInfo.LowerBaseDiameter / 2) * 2, 0), 0);

                baseSketch.EndEdit();
                Extrude(baseSketch, rookInfo.LowerBaseHeight);
            }
        }

        /// <summary>
        /// Создание верхнего элемента
        /// </summary>
        /// <param name="upperBaseHeight">Высота верхнего основания</param>
        /// <param name="upperBaseDiameter">Диаметр верхнего основания</param>
        private void CreateBattlement(int upperBaseHeight, int upperBaseDiameter, bool hasAnotherFeatures)
        {
            ksEntity battlePlane = _kompas.Part.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);
            ksEntity battleSketch = _kompas.Part.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition battleSketchDefinition = battleSketch.GetDefinition();
            battleSketchDefinition.SetPlane(battlePlane);

            battleSketch.Create();

            _kompas.Document2D = battleSketchDefinition.BeginEdit();

            //центр окружности, на которой будут отрисовываться зубчики
            var center = new Point();

            _kompas.Document2D.ksCircle(center.X, center.X, upperBaseDiameter / 2, 1);
            _kompas.Document2D.ksCircle(center.X, center.X, upperBaseDiameter / 2.2, 1);

            battleSketchDefinition.EndEdit();
            Extrude(battleSketchDefinition, upperBaseHeight);


            if (hasAnotherFeatures)
            {
                var sketch = CreateSketch(Obj3dType.o3d_planeXOZ,
                CreateOffsetPlane(Obj3dType.o3d_planeXOZ, upperBaseHeight / 2));
                _kompas.Document2D = (ksDocument2D)sketch.BeginEdit();

                _kompas.Document2D.ksRectangle(DrawRectangle(-upperBaseDiameter / 2,
                    -upperBaseDiameter / 16, upperBaseDiameter / 8, upperBaseDiameter, 0), 0);


                _kompas.Document2D.ksRectangle(DrawRectangle(-upperBaseDiameter / 16,
                    -upperBaseDiameter / 2, upperBaseDiameter, upperBaseDiameter / 8, 0), 0);

                sketch.EndEdit();
                СreateCutExtrusion(sketch, upperBaseHeight / 2);
            }
        }

        /// <summary>
        /// Выдавливание вращением
        /// </summary>
        /// <param name="sketch"> эскиз</param>
        private void Rotate(ksEntity sketch)
        {
            //интерфейс объекта "операция выдавливания вращением"
            ksEntity rotatedEntity =
                (ksEntity)_kompas.Part.NewEntity((short)Obj3dType.o3d_baseRotated);

            //интерфейс параметров операции  "выдавливание вращением"
            ksBaseRotatedDefinition rotateDefinition =
                (ksBaseRotatedDefinition)rotatedEntity.GetDefinition();
            rotateDefinition.directionType = (short)Direction_Type.dtBoth;
            rotateDefinition.SetSideParam(true, 360);
            rotateDefinition.SetSketch(sketch);
            rotatedEntity.Create();
        }

        /// <summary>
        /// Метод рисования прямоугольника
        /// </summary>
        /// <param name="x">X базовой точки</param>
        /// <param name="y">Y базовой точки</param>
        /// <param name="height">Высота</param>
        /// <param name="width">Ширина</param>
        /// <returns>Переменная с параметрами прямоугольника</returns>
        private ksRectangleParam DrawRectangle(double x, double y,
            double height, double width, double ang)
        {
            var rectangleParam =
                (ksRectangleParam)_kompas.Object.GetParamStruct
                    ((short)StructType2DEnum.ko_RectangleParam);
            rectangleParam.x = x;
            rectangleParam.y = y;
            rectangleParam.height = height;
            rectangleParam.width = width;
            rectangleParam.ang = ang;
            rectangleParam.style = 1;
            return rectangleParam;
        }


        /// <summary>
        /// Метод осуществляющий вырезание
        /// </summary>
        /// <param name="sketch">Эскиз</param>
        /// <param name="depth">Расстояние выреза</param>
        private void СreateCutExtrusion(ksSketchDefinition sketch,
            double depth, bool side = true)
        {
            var cutExtrusionEntity = (ksEntity)_kompas.Part.NewEntity(
                (short)ksObj3dTypeEnum.o3d_cutExtrusion);
            var cutExtrusionDef =
                (ksCutExtrusionDefinition)cutExtrusionEntity
                    .GetDefinition();

            cutExtrusionDef.SetSideParam(side,
                (short)End_Type.etBlind, depth);
            cutExtrusionDef.directionType = side ?
                (short)Direction_Type.dtNormal :
                (short)Direction_Type.dtReverse;
            cutExtrusionDef.cut = true;
            cutExtrusionDef.SetSketch(sketch);

            cutExtrusionEntity.Create();
        }

        /// <summary>
        /// Выдавливание
        /// </summary>
        /// <param name="sketch"> эскиз </param>
        /// <param name="upperBaseHeight"> высота верхнего основания </param>
        private void Extrude(ksSketchDefinition sketch, int upperBaseHeight)
        {
            int depth = upperBaseHeight;
            var extrudeEntity = (ksEntity)_kompas.Part
                .NewEntity((short)Obj3dType.o3d_bossExtrusion);
            // интерфейс базовой операции выдавливания
            var extrudeDefinition = (ksBossExtrusionDefinition)extrudeEntity
                .GetDefinition();
            // интерфейс структуры параметров выдавливания
            ksExtrusionParam extrudeParameters = (ksExtrusionParam)extrudeDefinition
                .ExtrusionParam();
            extrudeParameters.direction = (short)Direction_Type.dtNormal;
            // интерфейс структуры параметров тонкой стенки
            ksThinParam thinParam = (ksThinParam)extrudeDefinition.ThinParam();

            extrudeDefinition.SetSketch(sketch);
            // тип выдавливания (строго на глубину)
            extrudeParameters.typeNormal = (short)End_Type.etBlind;
            // глубина выдавливания
            extrudeParameters.depthNormal = -depth;
            // тонкая стенка в два направления
            thinParam.thin = false;
            //Толщина стенки в обратном направлении
            thinParam.reverseThickness = 0;

            //Направление формирования тонкой стенки
            thinParam.thinType = (short)Direction_Type.dtReverse;

            extrudeEntity.Create();
        }


        /// <summary>
        /// Метод смещающий плоскость
        /// </summary>
        /// <param name="plane">Плоскость</param>
        /// <param name="offset">Расстояние смещения</param>
        /// <returns>Объект смещения</returns>
        private ksEntity CreateOffsetPlane(Obj3dType plane, double offset)
        {
            var offsetEntity = (ksEntity)_kompas
                .Part.NewEntity((short)Obj3dType.o3d_planeOffset);
            var offsetDef = (ksPlaneOffsetDefinition)offsetEntity
                .GetDefinition();
            offsetDef.SetPlane((ksEntity)_kompas
                .Part.NewEntity((short)plane));
            offsetDef.offset = offset;
            offsetDef.direction = false;
            offsetEntity.Create();
            return offsetEntity;
        }

        /// <summary>
        /// Метод создающий эскиз
        /// </summary>
        /// <param name="planeType">Плоскость</param>
        /// <param name="offsetPlane">Объект смещения</param>
        /// <returns>Эскиз</returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType,
            ksEntity offsetPlane)
        {
            var plane = (ksEntity)_kompas.Part
                .GetDefaultEntity((short)planeType);

            var sketch = (ksEntity)_kompas.Part.
                NewEntity((short)Obj3dType.o3d_sketch);
            var ksSketch = (ksSketchDefinition)sketch.GetDefinition();

            if (offsetPlane != null)
            {
                ksSketch.SetPlane(offsetPlane);
                sketch.Create();
                return ksSketch;
            }

            ksSketch.SetPlane(plane);
            sketch.Create();
            return ksSketch;
        }
    }
}
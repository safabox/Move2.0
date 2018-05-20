namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingPlacementTest : DbMigration
    {
        public override void Up()
        {
            #region NIVELES
            Sql("SET IdENTITY_INSERT NivelTest ON");
            Sql("insert into NivelTest(Id, Numero, CantidadRespuestasIncorrectas, Nombre) values(1, 1, 3, 'Nivel Inicial')");
            Sql("insert into NivelTest(Id, Numero, CantidadRespuestasIncorrectas, Nombre) values(2, 2, 8, 'Nivel Elemental')");
            Sql("insert into NivelTest(Id, Numero, CantidadRespuestasIncorrectas, Nombre) values(3, 3, 5, 'Nivel Pre-Intermedio')");
            Sql("insert into NivelTest(Id, Numero, CantidadRespuestasIncorrectas, Nombre) values(4, 4, 4, 'Nivel Intermedio')");
            Sql("insert into NivelTest(Id, Numero, CantidadRespuestasIncorrectas, Nombre) values(5, 5, 2, 'Nivel Intermedio Alto')");
            Sql("insert into NivelTest(Id, Numero, CantidadRespuestasIncorrectas, Nombre) values(6, 6, 2, 'Nivel Avanzado')");
            Sql("SET IdENTITY_INSERT NivelTest OFF");
            #endregion

        }

        public override void Down()
        {
        }
    }
}

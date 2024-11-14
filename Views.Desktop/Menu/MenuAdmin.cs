using Models.Entity.Clases;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views.Desktop.Membresias;

namespace Views.Desktop.Menu
{
    internal class MenuAdmin
    {
        public MenuStrip CreateMenu(Form mdiParent)
        {
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem menuCruds = new ToolStripMenuItem("Cruds");

            ToolStripMenuItem menuCruds_Item1 = new ToolStripMenuItem("Gestión de Razas");
            menuCruds_Item1.Click += (sender, e) =>
            { CrudRazas menuCrudCliente = new CrudRazas(mdiParent); menuCrudCliente.Show(); };

            ToolStripMenuItem menuCruds_Item2 = new ToolStripMenuItem("Gestión de Usuarios");
            menuCruds_Item2.Click += (sender, e) =>
            { CrudUsuarios menuCrudCliente = new CrudUsuarios(mdiParent); menuCrudCliente.Show(); };

            ToolStripMenuItem menuCruds_Item3 = new ToolStripMenuItem("Gestión de Servicios");
            menuCruds_Item3.Click += (sender, e) =>
            { CrudServicios menuCrudServicios = new CrudServicios(mdiParent); menuCrudServicios.Show(); };

            ToolStripMenuItem menuCruds_Item4 = new ToolStripMenuItem("Gestión de Membresias");
            menuCruds_Item4.Click += (sender, e) =>
            { CrudMembresias menuCrudMembresias = new CrudMembresias(mdiParent); menuCrudMembresias.Show(); };

            ToolStripMenuItem menuCruds_Item5 = new ToolStripMenuItem("Gestión de Jornadas");
            menuCruds_Item5.Click += (sender, e) =>
            { CrudJornadas menuCrudJornadas = new CrudJornadas(mdiParent); menuCrudJornadas.Show(); };

            ToolStripMenuItem menuReportes = new ToolStripMenuItem("Reportes");

            ToolStripMenuItem menuCruds_Item1b = new ToolStripMenuItem("Atenciones e ingresos ultimo mes");
            menuCruds_Item1b.Click += (sender, e) =>
            {
                
                QuestPDF.Settings.License = LicenseType.Community;
                var a = PDFExporter.CreateDocument();
                a.GeneratePdf(@"C:\Users\matia\Desktop\ReporteBasico.pdf");
                MessageBox.Show("Se crearon correctamente los reportes");
            };


            menuCruds.DropDownItems.Add(menuCruds_Item1);
            menuCruds.DropDownItems.Add(menuCruds_Item2);
            menuCruds.DropDownItems.Add(menuCruds_Item3);
            menuCruds.DropDownItems.Add(menuCruds_Item4);
            menuCruds.DropDownItems.Add(menuCruds_Item5);


            menuReportes.DropDownItems.Add(menuCruds_Item1b);

            menuStrip.Items.Add(menuCruds);
            menuStrip.Items.Add(menuReportes);

            return menuStrip;
        }
    }
}

﻿using Models.Entity.Clases;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            ToolStripMenuItem menuReportes = new ToolStripMenuItem("Reportes");

            ToolStripMenuItem menuCruds_Item1b = new ToolStripMenuItem("Atenciones e ingresos ultimo mes");
            menuCruds_Item1.Click += (sender, e) =>
            {
                
                QuestPDF.Settings.License = LicenseType.Community;
                var a = PDFExporter.CreateDocument();
                a.GeneratePdf(@"C:\Users\matia\Desktop\ReporteBasico.pdf");
                MessageBox.Show("Se crearon correctamente los reportes");
            };


            menuCruds.DropDownItems.Add(menuCruds_Item1);
            menuCruds.DropDownItems.Add(menuCruds_Item2);
            menuCruds.DropDownItems.Add(menuCruds_Item3);
            
            menuReportes.DropDownItems.Add(menuCruds_Item1b);

            menuStrip.Items.Add(menuCruds);
            menuStrip.Items.Add(menuReportes);

            return menuStrip;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ImporteVehiculos.Classes;

namespace ImporteVehiculos.Formularios
{
    public partial class ReportesForm : Form
    {
        public LocalReport lc = new LocalReport();
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {



            if (Program.Greporte == "Factura Venta Vehículo")
            {
                FacturaVehiculo();
            }

            else if (Program.Greporte == "Reporte Vehículos Comprados")
            {
                ReporteVehiculosComprados();
            }

            else if (Program.Greporte == "Reporte Vehículos en Inventario")
            {
                ReporteVehiculosInventario();
            }

            else if (Program.Greporte == "Reporte Vehículos Vendidos")
            {
                ReporteVehiculosVendidos();
            }

            else if (Program.Greporte == "Cuentas por Pagar")
            {
                ReporteCuentasPagar();
            }

            else if (Program.Greporte == "Cuentas por Cobrar")
            {
                ReporteCuentasCobrar();
            }

            else if (Program.Greporte == "Reporte de Resultados ($RD)")
            {
                ReporteResultadosRD();
            }

            else if (Program.Greporte == "Reporte de Resultados ($USD)")
            {
                ReporteResultadosUSD();
            }

            else if (Program.Greporte == "Recibo de Pago") 
            {
                ReporteReciboDeCobro();
            }

            else if (Program.Greporte == "Reporte Efectivo Cobrado")
            {
                ReporteEfectivoCobrado();
            }

        }

        public void FacturaVehiculo()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\Factura.rdlc";

            CarsImportDataSet ds = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_factura_vehiculoTableAdapter rds = new CarsImportDataSetTableAdapters.reporte_factura_vehiculoTableAdapter();
            rds.Fill(ds.reporte_factura_vehiculo, Program.GidVehiculoRpt);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporte_factura_vehiculo"];

            CarsImportDataSet ds4 = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_individual_vehiculo_pagosTableAdapter rds4 = new CarsImportDataSetTableAdapters.reporte_individual_vehiculo_pagosTableAdapter();
            rds4.Fill(ds4.reporte_individual_vehiculo_pagos, Program.GidVehiculoRpt);  //llenar reporte
            ReportDataSource rd4 = new ReportDataSource();
            rd4.Name = "DataSet2";
            rd4.Value = ds4.Tables["reporte_individual_vehiculo_pagos"];

            CarsImportDataSet ds3 = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_factura_obtener_monto_pendienteTableAdapter rds3 = new CarsImportDataSetTableAdapters.reporte_factura_obtener_monto_pendienteTableAdapter();
            rds3.Fill(ds3.reporte_factura_obtener_monto_pendiente, Program.GidVehiculoRpt);  //llenar reporte
            ReportDataSource rd3 = new ReportDataSource();
            rd3.Name = "DataSet3";
            rd3.Value = ds3.Tables["reporte_factura_obtener_monto_pendiente"];

            parametros[0] = new ReportParameter("rptTitulo", Program.Gtitulo);
            parametros[1] = new ReportParameter("rptNombre", Program.Greporte);


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            lc.DataSources.Add(rd4);
            lc.DataSources.Add(rd3);
            this.reportViewer1.RefreshReport();


        }

        public void ReporteVehiculosComprados()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteComprados.rdlc";
            CarsImportDataSet ds = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_vehiculos_compradoTableAdapter rds = new CarsImportDataSetTableAdapters.reporte_vehiculos_compradoTableAdapter();
            rds.Fill(ds.reporte_vehiculos_comprado, Program.Gdesde, Program.Ghasta);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporte_vehiculos_comprado"];

            parametros[0] = new ReportParameter("rptTitulo", Program.Gtitulo);
            parametros[1] = new ReportParameter("rptNombre", Program.Greporte);
            parametros[2] = new ReportParameter("rptDesde", Program.Gdesde.ToString("dd/MM/yyyy"));
            parametros[3] = new ReportParameter("rptHasta", Program.Ghasta.ToString("dd/MM/yyyy"));



            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void ReporteVehiculosInventario()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteInventario.rdlc";
            CarsImportDataSet ds = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_vehiculos_inventarioTableAdapter rds = new CarsImportDataSetTableAdapters.reporte_vehiculos_inventarioTableAdapter();
            rds.Fill(ds.reporte_vehiculos_inventario, Program.Gdesde, Program.Ghasta);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporte_vehiculos_inventario"];

            parametros[0] = new ReportParameter("rptTitulo", Program.Gtitulo);
            parametros[1] = new ReportParameter("rptNombre", Program.Greporte);
            parametros[2] = new ReportParameter("rptDesde", Program.Gdesde.ToString("dd/MM/yyyy"));
            parametros[3] = new ReportParameter("rptHasta", Program.Ghasta.ToString("dd/MM/yyyy"));



            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void ReporteVehiculosVendidos()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteVendidos.rdlc";
            CarsImportDataSet ds = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_vehiculos_vendidosTableAdapter rds = new CarsImportDataSetTableAdapters.reporte_vehiculos_vendidosTableAdapter();
            rds.Fill(ds.reporte_vehiculos_vendidos, Program.Gdesde, Program.Ghasta);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporte_vehiculos_vendidos"];

            parametros[0] = new ReportParameter("rptTitulo", Program.Gtitulo);
            parametros[1] = new ReportParameter("rptNombre", Program.Greporte);
            parametros[2] = new ReportParameter("rptDesde", Program.Gdesde.ToString("dd/MM/yyyy"));
            parametros[3] = new ReportParameter("rptHasta", Program.Ghasta.ToString("dd/MM/yyyy"));



            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void ReporteCuentasPagar()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteCuentasPagar.rdlc";
            CarsImportDataSet ds = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_cuentas_pagarTableAdapter rds = new CarsImportDataSetTableAdapters.reporte_cuentas_pagarTableAdapter();
            rds.Fill(ds.reporte_cuentas_pagar, Program.Gdesde, Program.Ghasta);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporte_cuentas_pagar"];

            parametros[0] = new ReportParameter("rptTitulo", Program.Gtitulo);
            parametros[1] = new ReportParameter("rptNombre", Program.Greporte);
            parametros[2] = new ReportParameter("rptDesde", Program.Gdesde.ToString("dd/MM/yyyy"));
            parametros[3] = new ReportParameter("rptHasta", Program.Ghasta.ToString("dd/MM/yyyy"));

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void ReporteCuentasCobrar()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteCuentaCobrar.rdlc";
            CarsImportDataSet ds = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_cuentas_cobrarTableAdapter rds = new CarsImportDataSetTableAdapters.reporte_cuentas_cobrarTableAdapter();
            rds.Fill(ds.reporte_cuentas_cobrar, Program.Gdesde, Program.Ghasta);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporte_cuentas_cobrar"];

            parametros[0] = new ReportParameter("rptTitulo", Program.Gtitulo);
            parametros[1] = new ReportParameter("rptNombre", Program.Greporte);
            parametros[2] = new ReportParameter("rptDesde", Program.Gdesde.ToString("dd/MM/yyyy"));
            parametros[3] = new ReportParameter("rptHasta", Program.Ghasta.ToString("dd/MM/yyyy"));




            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void ReporteResultadosRD()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteResultadosRD.rdlc";
            CarsImportDataSet ds = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_resultados_rdTableAdapter rds = new CarsImportDataSetTableAdapters.reporte_resultados_rdTableAdapter();
            rds.Fill(ds.reporte_resultados_rd, Program.Gdesde, Program.Ghasta);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporte_resultados_rd"];

            parametros[0] = new ReportParameter("rptTitulo", Program.Gtitulo);
            parametros[1] = new ReportParameter("rptNombre", Program.Greporte);
            parametros[2] = new ReportParameter("rptDesde", Program.Gdesde.ToString("dd/MM/yyyy"));
            parametros[3] = new ReportParameter("rptHasta", Program.Ghasta.ToString("dd/MM/yyyy"));
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void ReporteResultadosUSD()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteResultadoUSD.rdlc";
            CarsImportDataSet ds = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_resultados_usdTableAdapter rds = new CarsImportDataSetTableAdapters.reporte_resultados_usdTableAdapter();
            rds.Fill(ds.reporte_resultados_usd, Program.Gdesde, Program.Ghasta);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporte_resultados_usd"];

            parametros[0] = new ReportParameter("rptNombre", Program.Greporte);
            parametros[1] = new ReportParameter("rptTitulo", Program.Gtitulo);
            parametros[2] = new ReportParameter("rptDesde", Program.Gdesde.ToString("dd/MM/yyyy"));
            parametros[3] = new ReportParameter("rptHasta", Program.Ghasta.ToString("dd/MM/yyyy"));
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void ReporteReciboDeCobro()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReciboCobro.rdlc";

            CarsImportDataSet ds = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_factura_vehiculoTableAdapter rds = new CarsImportDataSetTableAdapters.reporte_factura_vehiculoTableAdapter();
            rds.Fill(ds.reporte_factura_vehiculo, Program.GidVehiculoRpt);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporte_factura_vehiculo"];

            CarsImportDataSet ds2 = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_individual_vehiculo_pagosTableAdapter rds2 = new CarsImportDataSetTableAdapters.reporte_individual_vehiculo_pagosTableAdapter();
            rds2.Fill(ds2.reporte_individual_vehiculo_pagos, Program.GidVehiculoRpt);  //llenar reporte
            ReportDataSource rd2 = new ReportDataSource();
            rd2.Name = "DataSet2";
            rd2.Value = ds2.Tables["reporte_individual_vehiculo_pagos"];

            CarsImportDataSet ds3 = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_recibo_de_cobroTableAdapter rds3 = new CarsImportDataSetTableAdapters.reporte_recibo_de_cobroTableAdapter();
            rds3.Fill(ds3.reporte_recibo_de_cobro, Program.GidVehiculoRpt, Program.GtipoRecibo, Program.GnumeroRecibo);  //llenar reporte
            ReportDataSource rd3 = new ReportDataSource();
            rd3.Name = "DataSet3";
            rd3.Value = ds3.Tables["reporte_recibo_de_cobro"];

            CarsImportDataSet ds4 = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_obtener_detalle_cobrosTableAdapter rds4 = new CarsImportDataSetTableAdapters.reporte_obtener_detalle_cobrosTableAdapter();
            rds4.Fill(ds4.reporte_obtener_detalle_cobros, Program.GidVehiculoRpt, Program.GtipoRecibo, Program.GnumeroRecibo);  //llenar reporte
            ReportDataSource rd4 = new ReportDataSource();
            rd4.Name = "DataSet4";
            rd4.Value = ds4.Tables["reporte_obtener_detalle_cobros"];

            parametros[0] = new ReportParameter("rptTitulo", Program.Gtitulo);
            parametros[1] = new ReportParameter("rptNombre", Program.Greporte);


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            lc.DataSources.Add(rd2);
            lc.DataSources.Add(rd4);
            lc.DataSources.Add(rd3);
            this.reportViewer1.RefreshReport();


        }

        public void ReporteEfectivoCobrado()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteEfectivo.rdlc";
            CarsImportDataSet ds = new CarsImportDataSet();
            CarsImportDataSetTableAdapters.reporte_efectivo_cobradoTableAdapter rds =new CarsImportDataSetTableAdapters.reporte_efectivo_cobradoTableAdapter();
            rds.Fill(ds.reporte_efectivo_cobrado, Program.Gdesde, Program.Ghasta);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporte_efectivo_cobrado"];

            parametros[0] = new ReportParameter("rptNombre", Program.Greporte);
            parametros[1] = new ReportParameter("rptTitulo", Program.Gtitulo);
            parametros[2] = new ReportParameter("rptDesde", Program.Gdesde.ToString("dd/MM/yyyy"));
            parametros[3] = new ReportParameter("rptHasta", Program.Ghasta.ToString("dd/MM/yyyy"));
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }
    }
}

﻿using ChileSystems.DTE.Engine.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMPLEAPI_Demo
{
    public partial class ConsultaEstadoDTE : Form
    {
        Handler handler = new Handler();
        public ConsultaEstadoDTE()
        {
            InitializeComponent();
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            int rutReceptor = int.Parse(textRUTReceptor.Text);
            string dvReceptor = textDVReceptor.Text;
            int folio = int.Parse(textFolio.Text);
            int total = int.Parse(textTotal.Text);
            Enum.TryParse(comboTipoDTE.SelectedItem.ToString(), out TipoDTE.DTEType tipoDTE);
            try 
            {
                var responseEstadoDTE = handler.ConsultarEstadoDTE(radioProduccion.Checked, rutReceptor, dvReceptor, tipoDTE, folio, dateFechaEmision.Value.Date, total);
                textRespuesta.Text = responseEstadoDTE.ResponseXml;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex);
            }
        }

        private void ConsultaEstadoDTE_Load(object sender, EventArgs e)
        {
            foreach (var tipo in Enum.GetValues(typeof(TipoDTE.DTEType)))
            {
                comboTipoDTE.Items.Add(tipo);
            }
            handler.configuracion.LeerArchivo();
            textRUTEmpresa.Text = handler.configuracion.Empresa.RutCuerpo.ToString();
            textDVEmpresa.Text = handler.configuracion.Empresa.DV;
            textRUTEnvio.Text = handler.configuracion.Certificado.RutCuerpo.ToString();
            textDVEnvio.Text = handler.configuracion.Certificado.DV;
        }
    }
}

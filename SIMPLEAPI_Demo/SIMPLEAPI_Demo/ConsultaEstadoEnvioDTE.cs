﻿using System;
using ChileSystems.DTE.Engine.Enum;
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
    public partial class ConsultaEstadoEnvioDTE : Form
    {
        Handler handler = new Handler();
        public ConsultaEstadoEnvioDTE()
        {
            InitializeComponent();
        }

        private void ConsultaEstadoAvanzadoDTE_Load(object sender, EventArgs e)
        {
            handler.configuracion.LeerArchivo();
            textRUTEmpresa.Text = handler.configuracion.Empresa.RutCuerpo.ToString();
            textDVEmpresa.Text = handler.configuracion.Empresa.DV;
            textRUTEnvio.Text = handler.configuracion.Certificado.RutCuerpo.ToString();
            textDVEnvio.Text = handler.configuracion.Certificado.DV;
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            long trackId = long.Parse(textTrackID.Text);
            try
            {
                var responseEstadoDTE = handler.ConsultarEstadoEnvio(radioProduccion.Checked, trackId);
                textRespuesta.Text = responseEstadoDTE.ResponseXml;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex);
            }
        }
    }
}

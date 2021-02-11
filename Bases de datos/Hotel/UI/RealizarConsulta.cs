using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.DAO;
using Hotel.DTO;

namespace Hotel.UI {
    public partial class RealizarConsulta : Form {
        public RealizarConsulta ( ) {
            InitializeComponent();
            }        

        void HabilitarDatos ( ) {
            medicoLabel.Visible = true;
            nombreMedicoTB.Visible = true;
            apellidoMedicoTB.Visible = true;
            pacienteLabel.Visible = true;
            nombrePacienteTB.Visible = true;
            apellidoPacienteTB.Visible = true;
            lineShape1.Visible = true;
            lineShape2.Visible = true;
            lineShape3.Visible = true;
            lineShape4.Visible = true;
            recetaLabel.Visible = true;
            recetaRTB.Visible = true;
            guardarButton.Visible = true;
            diaDTP.Visible = false;
            horaCB.Visible = false;
            findButton.Visible = false;
            }

        void deshabilitarDatos ( ) {
            medicoLabel.Visible = false;
            nombreMedicoTB.Visible = false;
            apellidoMedicoTB.Visible = false;
            pacienteLabel.Visible = false;
            nombrePacienteTB.Visible = false;
            apellidoPacienteTB.Visible = false;
            lineShape1.Visible = false;
            lineShape2.Visible = false;
            lineShape3.Visible = false;
            lineShape4.Visible = false;
            recetaLabel.Visible = false;
            recetaRTB.Visible = false;
            guardarButton.Visible = false;
            diaDTP.Visible = true;
            horaCB.Visible = true;
            findButton.Visible = true;
            }

        private void findButton_Click ( object sender , EventArgs e ) {
            MedicoDao medico = new MedicoDao();
            PacienteDao paciente = new PacienteDao();
            RecetaDao receta = new RecetaDao();
            CitaDao cita = new CitaDao();

            MedicoDTO datosMedico = new MedicoDTO();
            PacienteDTO datosPaciente = new PacienteDTO();

            DateTime fecha = diaDTP.Value.Date;
            TimeSpan hora = TimeSpan.Parse(horaCB.Text);
            DateTime fechaCompleta = fecha.Add(hora);                      
            if ( !receta.existeReceta(fechaCompleta) ) {
                if ( cita.existeHorario(fechaCompleta) ) {
                    if ( cita.existeCita(fechaCompleta , CacheData.cedula) ) {
                        datosMedico = medico.ObtenerMedico(cita.ObtenerCita(fechaCompleta).Cedula);
                        datosPaciente = paciente.ObtenerPaciente(cita.ObtenerCita(fechaCompleta).Nss);
                        HabilitarDatos();
                        nombreMedicoTB.Text = datosMedico.Nombre;
                        apellidoMedicoTB.Text = datosMedico.Apellido;
                        nombrePacienteTB.Text = datosPaciente.Nombre;
                        apellidoPacienteTB.Text = datosPaciente.Apellido;
                        recetaLabel.Text = "Receta #" + receta.ultimaReceta().ToString();
                        }
                    else {
                        MessageBox.Show("La consulta no te pertenece");
                        }
                    }
                else {
                    MessageBox.Show("No hay cita con tal fecha y hora");
                    }
                }
            else {
                MessageBox.Show("La consulta ya fue realizada anteriormente");
                }
            }

        private void guardarButton_Click ( object sender , EventArgs e ) {
            RecetaDao receta = new RecetaDao();
            MedicoDao medico = new MedicoDao();
            PacienteDao paciente = new PacienteDao();
            CitaDao cita = new CitaDao();

            DateTime fecha = diaDTP.Value.Date;
            TimeSpan hora = TimeSpan.Parse(horaCB.Text);
            DateTime fechaCompleta = fecha.Add(hora);
            if ( recetaRTB.Text.Length >= 700 ) {
                MessageBox.Show("El tamaño de la receta excede el numero de caracteres requeridos");
                }
            else {                
                bool seGuardo = receta.Insert(receta.ultimaReceta(),nombreMedicoTB.Text,apellidoMedicoTB.Text,nombrePacienteTB.Text,apellidoPacienteTB.Text,cita.ObtenerCita(fechaCompleta).Cedula , cita.ObtenerCita(fechaCompleta).Nss ,fechaCompleta,recetaRTB.Text);
                if ( seGuardo ) {
                    MessageBox.Show("Consulta realizada correctamente");
                    }
                else {
                    MessageBox.Show("La consulta ya existe");
                    }
                deshabilitarDatos();
                }            
            }
        }
    }

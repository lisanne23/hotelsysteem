using domain.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_HotelSysteem.controller;

namespace WindowsFormsApp_HotelSysteem
{
    public partial class Form_Reservations : Form
    {
        public Form_Reservations()
        {
            InitializeComponent();
            logic.GuestsLogger.init();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            ReservationsController.AddUser(tb_Name.Text);
            updateListBox(ReservationsController.GetGuests());
        }

        private void updateListBox(IEnumerable<Guest> guests){
            lb_Guests.Items.Clear();
            foreach (Guest g in guests)
            {
                lb_Guests.Items.Add(g);
            }
        }
    }
}

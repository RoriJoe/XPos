using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.agungsetiawan.xpos.View.VTransaksiInternal
{
    public partial class TambahTransaksiInternal : Form
    {
        public ListTransaksiInternal ParentForm { get; set; }
        private TransaksiInternalService transaksiInternalService;
        public TambahTransaksiInternal()
        {
            InitializeComponent();

            transaksiInternalService = new TransaksiInternalService();

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd MMMM yyyy";

            comboBoxJenis.Items.Add("Kredit");
            comboBoxJenis.Items.Add("Debit");
        }

        private void TambahTransaksiInternal_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectTanggal = new Rectangle(panelTanggal.Location.X, panelTanggal.Location.Y,
                                                          panelTanggal.ClientSize.Width, panelTanggal.ClientSize.Height);

            System.Drawing.Rectangle rectKeterangan = new Rectangle(panelKeterangan.Location.X, panelKeterangan.Location.Y,
                                                         panelKeterangan.ClientSize.Width, panelKeterangan.ClientSize.Height);

            System.Drawing.Rectangle rectJumlah = new Rectangle(panelJumlah.Location.X, panelJumlah.Location.Y,
                                                         panelJumlah.ClientSize.Width, panelJumlah.ClientSize.Height);

            System.Drawing.Rectangle rectJenis = new Rectangle(comboBoxJenis.Location.X, comboBoxJenis.Location.Y,
                                                        comboBoxJenis.ClientSize.Width, comboBoxJenis.ClientSize.Height);

            rectTanggal.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectTanggal, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKeterangan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKeterangan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectJumlah.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectJumlah, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectJenis.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectJenis, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;
           
            if (string.IsNullOrEmpty(textBoxKeterangan.Text))
            {
                IsPass = false;
                sb.Append("- Keterangan harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxJumlah.Text))
            {
                IsPass = false;
                sb.Append("- Jumlah harus diisi \n");
            }

            if (!string.IsNullOrEmpty(textBoxJumlah.Text))
            {
                decimal result;
                bool IsHargaBeliPass = decimal.TryParse(textBoxJumlah.Text, out result);
                if (!IsHargaBeliPass)
                {
                    IsPass = false;
                    sb.Append("- Jumlah harus angka \n");
                }
            }

            if (string.IsNullOrEmpty(comboBoxJenis.Text))
            {
                IsPass = false;
                sb.Append("- Jenis harus diisi \n");
            }

            if (!IsPass)
            {
                MessageBox.Show(sb.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TransaksiInternal transaksiInternal = new TransaksiInternal()
            {
                Keterangan=textBoxKeterangan.Text,
                Tanggal=dateTimePicker.Value,
                Jumlah=decimal.Parse(textBoxJumlah.Text),
                Jenis=comboBoxJenis.Text
            };

            transaksiInternalService.Post(transaksiInternal);

            this.Dispose();
            this.ParentForm.dataGridViewTransaksiInternal.DataSource = transaksiInternalService.Get();
        }
    }
}

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

namespace com.agungsetiawan.xpos.View.VPembelian
{
    public partial class ListPembelian : Form
    {
        private static ListPembelian form;
        private PembelianService pembelianService;
        private PembelianDetailService pembelianDetailService;
        private ListPembelian()
        {
            InitializeComponent();

            pembelianService = new PembelianService();
            pembelianDetailService = new PembelianDetailService();

            dataGridViewDaftarPembelian.DataSource = pembelianService.FindWithSupplierDanPengguna();
            dataGridViewDaftarPembelian.Columns[0].Visible = false;

            comboBoxCari.Items.Add("Kode Transaksi");
            comboBoxCari.Items.Add("Supplier");
            comboBoxCari.Items.Add("Tanggal");

            comboBoxCari.SelectedItem = "Kode Transaksi";

            dateTimePickerCari.Format = DateTimePickerFormat.Custom;
            dateTimePickerCari.CustomFormat = "dd MMMM yyyy";
        }

        public static ListPembelian GetForm()
        {
            if (form == null || form.IsDisposed)
                form = new ListPembelian();

            return form;
        }

        private void dataGridViewDaftarPembelian_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDaftarPembelian.Rows.Count < 1)
                return;

            int id = 0;
            bool isValid;
            try
            {
                isValid = int.TryParse(dataGridViewDaftarPembelian.SelectedRows[0].Cells[0].Value.ToString(), out id);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                isValid = false;
            }


            if (!isValid || id == 0)
                return;

            dataGridViewDaftarPembelianDetail.DataSource = pembelianDetailService.FindByPembelianId(id);
            dataGridViewDaftarPembelianDetail.Columns[0].Visible = false;
            dataGridViewDaftarPembelianDetail.Columns[7].Visible = false;
        }

        private void comboBoxCari_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = comboBoxCari.SelectedItem.ToString();

            if (value.Equals("Tanggal"))
            {
                textBoxCari.Visible = false;
                dateTimePickerCari.Visible = true;

                panelCari.Controls.Add(dateTimePickerCari);
                dateTimePickerCari.Location = new Point(textBoxCari.Location.X, textBoxCari.Location.Y - 3);
            }

            if ((value.Equals("Kode Transaksi") || value.Equals("Supplier")) && dateTimePickerCari.Visible)
            {
                textBoxCari.Visible = true;
                dateTimePickerCari.Visible = false;

                textBoxCari.Location = new Point(dateTimePickerCari.Location.X, dateTimePickerCari.Location.Y);
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            var value = comboBoxCari.SelectedItem.ToString();
            if (value.Equals("Kode Transaksi"))
            {
                var result = pembelianService.FindByKodeTransaksi(textBoxCari.Text);

                dataGridViewDaftarPembelian.DataSource = result;

                textBoxCari.Text = string.Empty;
            }
            else if (value.Equals("Supplier"))
            {
                var result = pembelianService.FindBySupplier(textBoxCari.Text);

                dataGridViewDaftarPembelian.DataSource = result;

                textBoxCari.Text = string.Empty;
            }
            else if (value.Equals("Tanggal"))
            {
                var date = dateTimePickerCari.Value;
                dataGridViewDaftarPembelian.DataSource = pembelianService.FindByTanggal(date);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewDaftarPembelian.DataSource = pembelianService.FindWithSupplierDanPengguna();
        }

        private void ListPembelian_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectCari = new Rectangle(panelCari.Location.X, panelCari.Location.Y,
                                                                      panelCari.ClientSize.Width, panelCari.ClientSize.Height);

            System.Drawing.Rectangle rectComboCari = new Rectangle(panelComboCari.Location.X, panelComboCari.Location.Y,
                                                          panelComboCari.ClientSize.Width, panelComboCari.ClientSize.Height);

            rectCari.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectCari, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectComboCari.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectComboCari, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
       
        }

        private void dataGridViewDaftarPembelian_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            byte x = 0;
            DataGridView dgv = sender as DataGridView;
            String index = (e.RowIndex + 1).ToString();
            System.Drawing.Font font = new Font("Tahoma", 8.0f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, x);

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Center;

            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                dgv.RowHeadersWidth, e.RowBounds.Height);

            e.Graphics.DrawString(index, font, SystemBrushes.ControlText,
                headerBounds, centerFormat);
        }

        private void dataGridViewDaftarPembelianDetail_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            byte x = 0;
            DataGridView dgv = sender as DataGridView;
            String index = (e.RowIndex + 1).ToString();
            System.Drawing.Font font = new Font("Tahoma", 8.0f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, x);

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Center;

            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                dgv.RowHeadersWidth, e.RowBounds.Height);

            e.Graphics.DrawString(index, font, SystemBrushes.ControlText,
                headerBounds, centerFormat);
        }
    }
}

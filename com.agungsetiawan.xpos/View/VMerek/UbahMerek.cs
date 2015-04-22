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

namespace com.agungsetiawan.xpos.View.VMerek
{
    public partial class UbahMerek : Form
    {
        public ListMerek ParentForm { get; set; }
        private MerekService merekService;
        public UbahMerek()
        {
            InitializeComponent();
            merekService = new MerekService();
            this.ActiveControl = this.textBoxNamaMerek;
        }

        public void PopulateData()
        {
            int id = int.Parse(this.ParentForm.dataGridViewMerek.SelectedRows[0].Cells[0].Value.ToString());
            var merek = merekService.Get(id);

            labelIdHidden.Text = id.ToString();
            textBoxNamaMerek.Text = merek.NamaMerek;
            textBoxKeterangan.Text = merek.Keterangan;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;

            if (string.IsNullOrEmpty(textBoxNamaMerek.Text))
            {
                sb.Append("- Nama Merek harus diisi \n");
                IsPass = false;
            }

            if (string.IsNullOrEmpty(textBoxKeterangan.Text))
            {
                sb.Append("- Keterangan harus diisi \n");
                IsPass = false;
            }

            if (!IsPass)
            {
                MessageBox.Show(sb.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var merek = merekService.Get(int.Parse(labelIdHidden.Text));
            merek.NamaMerek = textBoxNamaMerek.Text;
            merek.Keterangan = textBoxKeterangan.Text;

            merekService.Put(merek);

            this.ParentForm.dataGridViewMerek.DataSource = merekService.Get();
            this.Dispose();
        }

        private void UbahMerek_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectNamaMerek = new Rectangle(panelNamaMerek.Location.X, panelNamaMerek.Location.Y,
                                                        panelNamaMerek.ClientSize.Width, panelNamaMerek.ClientSize.Height);

            System.Drawing.Rectangle rectKeterangan = new Rectangle(panelKeterangan.Location.X, panelKeterangan.Location.Y,
                                                          panelKeterangan.ClientSize.Width, panelKeterangan.ClientSize.Height);

            rectNamaMerek.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNamaMerek, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKeterangan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKeterangan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }
    }
}

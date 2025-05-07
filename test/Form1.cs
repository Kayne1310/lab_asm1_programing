using iTextSharp.text.pdf;
using iTextSharp.text;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomer.Text.Trim();
            string customerType = cbCustomer.SelectedItem?.ToString();

            bool isValid = true;
            string errorMessage = "";

            // Kiểm tra tên khách hàng
            if (string.IsNullOrWhiteSpace(customerName))
            {
                errorMessage += "- Please enter customer name.\n";
                isValid = false;
            }

            // Kiểm tra loại khách hàng
            if (string.IsNullOrWhiteSpace(customerType) || cbCustomer.SelectedIndex == -1)
            {
                errorMessage += "- Please select customer type.\n";
                isValid = false;
            }

            // Kiểm tra số người
            if (!int.TryParse(txtPop.Text, out int population) || population <= 0)
            {
                errorMessage += "- Population must be a positive integer.\n";
                isValid = false;
            }

            // Kiểm tra chỉ số nước
            if (!double.TryParse(txtWaterIndexLastMonth.Text, out double lastMonth) || lastMonth < 0)
            {
                errorMessage += "- Water index last month must be a non-negative number.\n";
                isValid = false;
            }

            if (!double.TryParse(txtWaterIndexThisMonth.Text, out double thisMonth) || thisMonth < 0)
            {
                errorMessage += "- Water index this month must be a non-negative number.\n";
                isValid = false;
            }

            double consumption = thisMonth - lastMonth;
            if (consumption < 0)
            {
                errorMessage += "- Water index this month must be greater than or equal to last month.\n";
                isValid = false;
            }

            // Nếu có lỗi, hiển thị và dừng
            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalAmount = 0;

            // Hiển thị thông tin lên các label
            lbCustomer.Text = customerName;
            lbTypeCustomer.Text = customerType;
            lbWaterIndexLastMonth.Text = lastMonth.ToString();
            lbWaterIndexThisMonth.Text = thisMonth.ToString();
            lbWaterIndex.Text = consumption.ToString();

            if (consumption < 0)
            {
                MessageBox.Show("Water index this month must be greater than or equal to last month.");
                return;
            }

            if (customerType == "Household customer")
            {
                double consumptionPerPerson = consumption / population;

                double remain = consumption;
                double price = 0;

                // Case 1: đến 10 m3/người
                double tier1 = Math.Min(remain, population * 10);
                price += tier1 * 5973;
                remain -= tier1;

                // Case 2: từ 10-20 m3/người
                double tier2 = Math.Min(remain, population * 10);
                price += tier2 * 7052;
                remain -= tier2;

                // Case 3: từ 20-30 m3/người
                double tier3 = Math.Min(remain, population * 10);
                price += tier3 * 8699;
                remain -= tier3;

                // Trên 30 m3/người
                if (remain > 0)
                {
                    price += remain * 15929;
                }

                double VAT = price * 0.10;
                totalAmount = price + VAT;
            }
            else
            {
                double unitPrice = 0;

                switch (customerType)
                {
                    case "Administrative agency, public services":
                        unitPrice = 9955;
                        break;
                    case "Production units":
                        unitPrice = 11615;
                        break;
                    case "Business services":
                        unitPrice = 22068;
                        break;
                }

                double price = consumption * unitPrice;
                double VAT = price * 0.10;
                totalAmount = price + VAT;
            }

            lbTotalAmount.Text = $"{totalAmount:N0} VND";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            saveFileDialog.FileName = "WaterBill.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4);
                try
                {
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Tiêu đề
                    iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    iTextSharp.text.Font fwbold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                    Paragraph title = new Paragraph("WATER BILL INVOICE", titleFont)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(title);
                    doc.Add(new Paragraph(" ")); // dòng trống

                    // Thêm thông tin khách hàng
                    doc.Add(new Paragraph($"Customer Name: {lbCustomer.Text}", fwbold)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });
                    doc.Add(new Paragraph($"Customer Type: {lbTypeCustomer.Text}")
                    {
                        Alignment = Element.ALIGN_CENTER
                    });
                    doc.Add(new Paragraph($"Water Index Last Month: {lbWaterIndexLastMonth.Text}") { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph($"Water Index This Month: {lbWaterIndexThisMonth.Text}") { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph($"Consumption (m3): {lbWaterIndex.Text}") { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph($"Total Amount (VND): {lbTotalAmount.Text}") { Alignment = Element.ALIGN_CENTER });

                    MessageBox.Show("PDF exported successfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting PDF: " + ex.Message);
                }
                finally
                {
                    doc.Close();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomer.Clear();
            txtWaterIndexLastMonth.Clear();
            txtWaterIndexThisMonth.Clear();
            txtPop.Clear();
            lbCustomer.Text = "";
            lbTypeCustomer.Text = "";
            lbWaterIndexLastMonth.Text = "";
            lbWaterIndexThisMonth.Text = "";
            lbWaterIndex.Text = "";
            lbTotalAmount.Text = "";
            cbCustomer.SelectedIndex = -1;
            txtCustomer.Focus();
        }
    }
}

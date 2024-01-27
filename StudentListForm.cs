using Giaolang.LINQ.V3.StudentMgt;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StudentListForm : Form
    {
        List<Student> _ds = new List<Student>();

        public StudentListForm()
        {
            InitializeComponent();

            // Call the method to customize the header
            CustomizeDataGridViewHeader();

            // Initialize data
            InitData();
        }

        private void InitData()
        {
            _ds.Add(new Student() { Id = "SE1", Name = "An", Address = "Dĩ An", Gpa = 8.8, Yob = 2003 });
            _ds.Add(new Student() { Id = "SE2", Name = "Bình", Address = "Bình Dương", Gpa = 9.0, Yob = 2008 });
            _ds.Add(new Student() { Id = "SE5", Name = "Dương", Address = "Tân Bình", Gpa = 5.0, Yob = 2005 });
            _ds.Add(new Student() { Id = "SE4", Name = "Dũng", Address = "Châu Thành", Gpa = 5.0, Yob = 2006 });
            _ds.Add(new Student() { Id = "SE3", Name = "Thành", Address = "Long An", Gpa = 8.0, Yob = 2000 });
            _ds.Add(new Student() { Id = "SE6", Name = "Thinh", Address = "Rach Gia", Gpa = 8.2, Yob = 2001 });
            _ds.Add(new Student() { Id = "SE8", Name = "Xuan", Address = "Long An", Gpa = 8.3, Yob = 2003 });
            _ds.Add(new Student() { Id = "SE7", Name = "Trinh", Address = "Bến tre", Gpa = 7.9, Yob = 2002 });
        }

        private void CustomizeDataGridViewHeader()
        {
            // Set the header style
            /* Set the EnableHeadersVisualStyles flag for the data grid view to False, 
             * and set the background colour via the ColumnHeadersDefaultCellStyle.BackColor property*/
            dgvStudentList.EnableHeadersVisualStyles = false;
            dgvStudentList.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua; // Optional: Change the background color of the header
            dgvStudentList.ColumnHeadersDefaultCellStyle.Font = new Font(dgvStudentList.Font, FontStyle.Bold); // Make the font bold
            dgvStudentList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Optional: Align text to center
                                                                                                                // 

        }

        private void SayHello(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!!!",
                            "Notification",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification
                            );
        }

        private void SayGoodBye(object sender, EventArgs e)
        {

        }

        private void SayGoodbye(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to exit?", "Notification"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK) this.Close();
        }

        private void OpenImage(object sender, EventArgs e)
        {
            DialogResult res = dlgOF.ShowDialog();
            if (res == DialogResult.Cancel) return;

            lblFileName.Text = dlgOF.FileName;
            picAvatar.Image = new Bitmap(dlgOF.FileName);
        }

        private void LoadData(object sender, EventArgs e)
        {
            dgvStudentList.DataSource = _ds;    //1983  andr
            //const int WIDTH = 70;
            //dgvStudentList.Columns[0].Width = WIDTH;
            //dgvStudentList.Columns[1].Width = WIDTH;
            //dgvStudentList.Columns[2].Width = 100;
            //dgvStudentList.Columns[3].Width = WIDTH;
            //dgvStudentList.Columns[4].Width = WIDTH;
        }

        private void ShowAStudent(object sender, EventArgs e)
        {
            if (dgvStudentList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudentList.SelectedRows[0]; // 1st row in selected rows
                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtYob.Text = selectedRow.Cells[3].Value.ToString();
                txtGpa.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void AddNewStudent(object sender, EventArgs e)
        {
            // create new Student
            if (_ds.Where(x => x.Id.Equals(txtID.Text)).Select(x => x.Id).ToArray().Length > 0)
            {
                MessageBox.Show("ID is already exits!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            // add to _ds
            _ds.Add(new Student()
            {
                Id = txtID.Text,
                Name = txtName.Text,
                Address = txtAddress.Text,
                Gpa = double.Parse(txtGpa.Text),
                Yob = int.Parse(txtYob.Text)
            });

            // clear grid
            dgvStudentList.DataSource = null;

            // view grid again
            dgvStudentList.DataSource = _ds;
        }

        private void SearchStudents(object sender, EventArgs e)
        {
            var result = _ds.Where(x => x.Name.ToLower().Contains(txtSearch.Text.ToLower()) 
                                    || x.Address.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            if (result.Count > 0)
            {
                dgvSearchResult.DataSource = result;
            }
            else
            {
                MessageBox.Show("No student found!");
            }

        }
    }
}
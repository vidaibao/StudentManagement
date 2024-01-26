using Giaolang.LINQ.V3.StudentMgt;

namespace StudentManagement
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
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
            List<Student> ds = new List<Student>()
            {
                new Student() {Id = "SE1", Name = "An", Address = "Dĩ An", Gpa = 8.8, Yob = 2003},
                new Student() {Id = "SE2", Name = "Bình", Address = "Bình Dương", Gpa = 9.0, Yob = 2008},
                new Student() {Id = "SE5", Name = "Dương", Address = "Tân Bình", Gpa = 5.0, Yob = 2005},
                new Student() {Id = "SE4", Name = "Dũng", Address = "Châu Thành", Gpa = 5.0, Yob = 2006},
                new Student() {Id = "SE3", Name = "Thành", Address = "Long An", Gpa = 8.0, Yob = 2000},
                new Student() {Id = "SE6", Name = "Thinh", Address = "Rach Gia", Gpa = 8.2, Yob = 2001},
                new Student() {Id = "SE8", Name = "Xuan", Address = "Long An", Gpa = 8.3, Yob = 2003},
                new Student() {Id = "SE7", Name = "Trinh", Address = "Ben tre", Gpa = 7.9, Yob = 2002},
            };

            dgvStudentList.DataSource = ds;
        }
    }
}
namespace TestDataGenerator
{
    #region Usings
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading;
    using System.Windows.Forms;
    #endregion


    public partial class Form1 : Form
    {
        string constInsertDepartment = "INSERT department (name, description) VALUES ('{0}', '{1}')";
        string constInsertPosition = "INSERT position (name, description, salary) VALUES ('{0}', '{1}', {2})";
        string constInsertEmployee = "INSERT employee (f_name, s_name, dob, pesel, department_id, position_id) VALUES ('{0}', '{1}', Convert(DateTime,'{2}',120), {3}, {4}, {5})";
        string constInsertProduct = "INSERT product (sn, name, description, price) VALUES ('{0}', '{1}', '{2}', {3} )";
        string constInsertOrderStatus = "INSERT order_status ( name, description) VALUES ('{0}', '{1}')";
        string constInsertDelivery = "INSERT delivery ( name, time, price) VALUES ('{0}', {1}, {2})";
        string constInsertOrder = "INSERT \"order\" ( f_name, s_name, address, phone, email, ordered_date, delivery_id, order_status_id) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', Convert(DateTime,'{5}',120), {6}, {7})";
        string constInsertOrderProduct = "INSERT order_product ( order_id, product_id, quantity) VALUES ({0}, {1}, {2})";
        string connectionString = string.Empty;
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void testConnectionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connectionStringTxtBox.Text != string.Empty)
                {
                    connectionString = connectionStringTxtBox.Text;
                }
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                MessageBox.Show("Good connection string!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not connect to database! " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateTestData_Click(object sender, EventArgs e)
        {
            if (connectionStringTxtBox.Text != string.Empty)
            {
                connectionString = connectionStringTxtBox.Text;
            }
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                MyInsertDepartments();
                MyInsertPositions();
                MyInsertEmplyees();
                MyInsertDelivery();
                MyInsertOrderStatus();
                MyInsertProducts();
                MyInsertOrders();
                MyInsertOrderProducts();
                sqlConnection.Close();
                MessageBox.Show("Generating test data successful!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not generate test data! " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyInsertDepartments()
        {
            var cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;
            for (int i = 0; i < (TestData.DepartmentNameAndDescription.Length / 2); i++)
            {
                var departmentName = TestData.DepartmentNameAndDescription[i, 0];
                var departmentDescription = TestData.DepartmentNameAndDescription[i, 1];
                cmd.CommandText = string.Format(constInsertDepartment, departmentName, departmentDescription);
                cmd.ExecuteNonQuery();
            }
        }

        private void MyInsertPositions()
        {
            Random rand = new Random();
            var cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;
            double maximum = 10000;
            double minimum = 1000;
            for (int i = 0; i < (TestData.PositionNameAndDescription.Length / 2); i++)
            {
                var positionName = TestData.PositionNameAndDescription[i, 0];
                var positionDescription = TestData.PositionNameAndDescription[i, 1];
                Thread.Sleep(100);
                double salary = rand.NextDouble() * (maximum - minimum) + minimum;
                cmd.CommandText = string.Format(constInsertPosition, positionName, positionDescription, salary.ToString().Replace(',', '.'));
                cmd.ExecuteNonQuery();
            }
        }

        private void MyInsertEmplyees()
        {
            var cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;
            Random rand = new Random();
            int maximumFirst = TestData.Firstname.Length;
            int maximumSur = TestData.Surname.Length;

            int maximumDepartment = TestData.DepartmentNameAndDescription.Length / 2 + 1;
            int maximumPosition = TestData.PositionNameAndDescription.Length / 2 + 1;

            for (int i = 0; i < int.Parse(employeesCountTxtBox.Text); i++)
            {
                string firstName = TestData.Firstname[rand.Next(TestData.Firstname.Length - 1)];

                Thread.Sleep(100);
                string surName = TestData.Surname[rand.Next(TestData.Surname.Length - 1)];

                var date = MyRandomDay(new DateTime(1945, 1, 1));

                string pesel = date.Year.ToString() + date.Month.ToString() + date.Day.ToString();

                Thread.Sleep(100);
                var departmentId = rand.Next(TestData.DepartmentNameAndDescription.Length / 2) + 1;

                Thread.Sleep(100);
                var positionId = rand.Next(TestData.PositionNameAndDescription.Length / 2) + 1;

                cmd.CommandText = string.Format(constInsertEmployee, firstName, surName, date.ToString("yyyy-MM-dd"), pesel, departmentId, positionId);
                cmd.ExecuteNonQuery();
            }
        }

        private void MyInsertDelivery()
        {
            var cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;

            for (int i = 0; i < (TestData.DeliveryName.Length); i++)
            {
                var deliveryName = TestData.DeliveryName[i];
                var deliveryTime = TestData.DeliveryTime[i];
                var deliveryPrice = TestData.DeliveryPrice[i];
                cmd.CommandText = string.Format(constInsertDelivery, deliveryName, deliveryTime, deliveryPrice.ToString().Replace(',', '.'));
                cmd.ExecuteNonQuery();
            }
        }

        private void MyInsertOrderStatus()
        {
            var cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;
            for (int i = 0; i < (TestData.OrderStatusNameAndDescription.Length / 2); i++)
            {
                var orderStatusName = TestData.OrderStatusNameAndDescription[i, 0];
                var orderStatusDescription = TestData.OrderStatusNameAndDescription[i, 1];
                cmd.CommandText = string.Format(constInsertOrderStatus, orderStatusName, orderStatusDescription);
                cmd.ExecuteNonQuery();
            }
        }

        private void MyInsertProducts()
        {
            var cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;
            Random rand = new Random();
            double maximum = 1000;
            double minimum = 50;

            for (int i = 0; i < int.Parse(productsCountTxtBox.Text); i++)
            {
                Thread.Sleep(100);
                var productName = TestData.ProductName[rand.Next(TestData.ProductName.Length - 1)];
                var productDescription = productName + TestData.ProductDescription[rand.Next(TestData.ProductDescription.Length - 1)];
                double productPrice = rand.NextDouble() * (maximum - minimum) + minimum;
                int serialNumber = rand.Next(100000, 999999);
                cmd.CommandText = string.Format(constInsertProduct, serialNumber, productName, productDescription, productPrice.ToString().Replace(',', '.'));
                cmd.ExecuteNonQuery();
            }
        }

        private void MyInsertOrders()
        {
            var cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;
            Random rand = new Random();

            for (int i = 0; i < int.Parse(ordersCountTxtBox.Text); i++)
            {
                Thread.Sleep(100);
                string firstName = TestData.Firstname[rand.Next(TestData.Firstname.Length - 1)];

                Thread.Sleep(100);
                string surName = TestData.Surname[rand.Next(TestData.Surname.Length - 1)];
                var address = TestData.Cities[rand.Next(TestData.Cities.Length - 1)] + ", " + TestData.Streets[rand.Next(TestData.Streets.Length - 1)] + " " + rand.Next(100).ToString();
                int phoneNumber = rand.Next(100000000, 999999999);
                string email = firstName.ToLower() + surName.ToLower() + "@" + TestData.EmailDomen[rand.Next(TestData.EmailDomen.Length - 1)];
                var orderedDate = MyRandomDay(new DateTime(2015, 1, 1)).ToString("yyyy-MM-dd");
                var orderStatusId = rand.Next(1, TestData.OrderStatusNameAndDescription.Length / 2);
                var deliveryId = rand.Next(1, TestData.DeliveryName.Length);
                cmd.CommandText = string.Format(constInsertOrder, firstName, surName, address, phoneNumber, email, orderedDate, deliveryId, orderStatusId);
                cmd.ExecuteNonQuery();
            }
        }

        private void MyInsertOrderProducts()
        {
            var cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;
            Random rand = new Random();

            for (int i = 0; i < int.Parse(ordersCountTxtBox.Text); i++)
            {
                int orderId = rand.Next(1, int.Parse(ordersCountTxtBox.Text));
                int productId = rand.Next(1, int.Parse(ordersCountTxtBox.Text));
                int quantity = rand.Next(1, 20);
               
                cmd.CommandText = string.Format(constInsertOrderProduct, orderId, productId, quantity);
                cmd.ExecuteNonQuery();
            }
        }

        DateTime MyRandomDay(DateTime start)
        {
            Random rand = new Random();

            int range = (DateTime.Today - start).Days;
            return start.AddDays(rand.Next(range));
        }

    }
}

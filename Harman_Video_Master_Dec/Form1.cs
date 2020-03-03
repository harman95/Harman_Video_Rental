using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harman_Video_Master_Dec
{
    public partial class Form1 : Form
    {
        private int err = 0, RentID = 0, CustID = 0, MovID = 0, Video_Cost = 0;

        //here global object is created for the main class
        Database data_base = new Database();

        Rental rental_obj = new Rental();

        public Form1()
        {
            InitializeComponent();
        }
        public int chkVideo()
        {
            if (title.Text.ToString().Equals(""))
            {
                error.SetError(title, "Enter Title of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Year.Text.ToString().Equals(""))
            {
                error.SetError(Year, "Enter Year of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Ratting.Text.ToString().Equals(""))
            {
                error.SetError(Ratting, "Enter Ratting of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Cost.Text.ToString().Equals(""))
            {
                error.SetError(Cost, "Enter Cost of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Copies.Text.ToString().Equals(""))
            {
                error.SetError(Copies, "Enter Cost of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Plot.Text.ToString().Equals(""))
            {
                error.SetError(Plot, "Enter Plot of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Genre.Text.ToString().Equals(""))
            {
                error.SetError(Genre, "Enter Genre of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }


            if (err == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        private void AddVideo_Click(object sender, EventArgs e)
        {
            //if condition for record checking 
            if (chkVideo() == 1)
            {

                // insert the query 
                String query = "insert into Video_Record(Video_Title,Video_Ratting,Video_Year,Video_Cost,Video_Copies,Video_Plot,Video_Genre) values('" + title.Text.ToString() + "','" + Ratting.Text.ToString() + "'," + Convert.ToInt32(Year.Text.ToString()) + "," + Convert.ToInt32(Cost.Text.ToString()) + "," + Convert.ToInt32(Copies.Text.ToString()) + ",'" + Plot.Text.ToString() + "','" + Genre.Text.ToString() + "')";
                data_base.InsDelUpdt(query);
                MessageBox.Show("Video Record is Saved");
                //refresh all text box after inserting the record in the table
                title.Text = "";
                Year.Text = "";
                Ratting.Text = "";
                Cost.Text = "";
                Copies.Text = "";
                Plot.Text = "";
                Genre.Text = "";
                query = "select * from Video_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                //display the error 
                MessageBox.Show("Fill the Record Properly ");
            }
            err = 0;

        }
        // this function is checking that all text boxes should be filled
        public int chkCustomer()
        {
            if (FirstName.Text.ToString().Equals(""))
            {
                error.SetError(FirstName, "Enter First Name of Customer");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (LastName.Text.ToString().Equals(""))
            {
                error.SetError(LastName, "Enter Last Name of the Customer");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (MobileNo.Text.ToString().Equals(""))
            {
                error.SetError(MobileNo, "Enter Mobile No of the Customer");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Address.Text.ToString().Equals(""))
            {
                error.SetError(Address, "Enter Address of the Customer");
                err++;
            }
            else
            {
                error.Clear();
            }



            if (err == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        // if by mistake any record is not entered in the database system will show error
        public int chkRental()
        {
            if (customerID.Text.ToString().Equals(""))
            {
                error.SetError(customerID, "Select Customer ID ");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (movieID.Text.ToString().Equals(""))
            {
                error.SetError(movieID, "Select Movie ID");
                err++;
            }
            else
            {
                error.Clear();
            }





            if (err == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        private void updateVideo_Click(object sender, EventArgs e)
        {
           // for updating video record and if is used to see weather the movie id is empty or not
            if (!movieID.Text.Equals(""))
            {
                string query = "update Video_Record set Video_Title='" + title.Text.ToString() + "',Video_Ratting='" + Ratting.Text.ToString() + "',Video_Year=" + Convert.ToInt32(Year.Text.ToString()) + ",Video_Cost=" + Convert.ToInt32(Cost.Text.ToString()) + ",Video_Copies=" + Convert.ToInt32(Copies.Text.ToString()) + ",Video_Plot='" + Plot.Text.ToString() + "',Video_Genre='" + Genre.Text.ToString() + "' where Video_ID=" + Convert.ToInt32(movieID.Text.ToString()) + "";
                data_base.InsDelUpdt(query);
                MessageBox.Show("Record is Updated");
                query = "select * from Video_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                MessageBox.Show("Select the Video First");
            }

            title.Text = "";
            Year.Text = "";
            Ratting.Text = "";
            Cost.Text = "";
            Copies.Text = "";
            Plot.Text = "";
            Genre.Text = "";
            movieID.Text = "";


        }

        private void delVideo_Click(object sender, EventArgs e)
        {
            // if the movie iis on issue it stop to delete it.
            if (!movieID.Text.Equals(""))
            {
                String query = "delete from Video_Record  where Video_ID=" + Convert.ToInt32(movieID.Text.ToString()) + "";
                data_base.InsDelUpdt(query);
                MessageBox.Show("Record is Deleted");
                query = "select * from Video_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                MessageBox.Show("Select the Video First");
            }

            title.Text = "";
            Year.Text = "";
            Ratting.Text = "";
            Cost.Text = "";
            Copies.Text = "";
            Plot.Text = "";
            Genre.Text = "";
            movieID.Text = "";

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (chkCustomer() == 1)
            {
                //record to insert the record in the table
                String query = "insert into Customer_Record(Customer_FirstName,Customer_LastName,Customer_Mobile,Customer_Address)values('" + FirstName.Text.ToString() + "','" + LastName.Text.ToString() + "','" + MobileNo.Text.ToString() + "','" + Address.Text.ToString() + "')";
                data_base.InsDelUpdt(query);
                MessageBox.Show("Customer Record is Saved");
                // refresh the data grid view
                query = "select * from Customer_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                MessageBox.Show("Fill all the Record of the Customer");
            }
            err = 0;
            FirstName.Text = "";
            LastName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";

        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            //update the customer recrod after verifing 
            if (!customerID.Text.ToString().Equals(""))

            {
                String query = "Update Customer_Record set Customer_FirstName='" + FirstName.Text.ToString() + "',Customer_LastName='" + LastName.Text.ToString() + "',Customer_Mobile='" + MobileNo.Text.ToString() + "',Customer_Address='" + Address.Text.ToString() + "' where Customer_ID=" + Convert.ToInt32(customerID.Text.ToString()) + "";
                data_base.InsDelUpdt(query);
                MessageBox.Show("Customer Record is Deleted");
                query = "select * from Customer_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                MessageBox.Show("Select the Customer Record ");
            }

            FirstName.Text = "";
            LastName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";
            customerID.Text = "";



        }

        private void delCustomer_Click(object sender, EventArgs e)
        {
            // for deleting customer
            if (!customerID.Text.ToString().Equals(""))
            {
                String query = "delete from Customer_Record where Customer_ID=" + Convert.ToInt32(customerID.Text.ToString()) + "";
                data_base.InsDelUpdt(query);
                MessageBox.Show("Customer Record is Deleted");
                query = "select * from Customer_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                MessageBox.Show("Select the Customer Record ");
            }
            FirstName.Text = "";
            LastName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";
            customerID.Text = "";
        }

        private void MovieRatting_Click(object sender, EventArgs e)
        {
           // to view top ratted movie

            String query = "select * from Video_Cunt ORDER BY CountNo DESC";
            DataTable recrdTbl = data_base.Srch(query);
            MessageBox.Show("Top Most Viewed Movie ID is==" + recrdTbl.Rows[0]["MovieID"]);


        }

        public void Video_Cunt()
        {

            // couting the videos for top video to show
            int Count = 0;
            DataTable recrdtbl = new DataTable();
            String query = "select * from Video_Cunt where MovieID=" + Convert.ToInt32(movieID.Text.ToString()) + "";
            recrdtbl = data_base.Srch(query);
            if (recrdtbl.Rows.Count > 0)
            {
                Count = Convert.ToInt32(recrdtbl.Rows[0]["CountNo"].ToString());
                query = "";
                Count++;
                query = "Update Video_Cunt set CountNo=" + Count + " where MovieID=" + Convert.ToInt32(movieID.Text.ToString()) + " ";
                data_base.InsDelUpdt(query);


            }
            else
            {
                query = "insert into Video_Cunt(MovieID,CountNo) values(" + Convert.ToInt32(movieID.Text.ToString()) + ",1)";
                data_base.InsDelUpdt(query);

            }

            MessageBox.Show("data executed");
            DataTable recrdtbl1 = new DataTable();

            query = "";

            query = "select * from Customer_Cunt where CustomerID=" + Convert.ToInt32(customerID.Text.ToString()) + "";
            recrdtbl1 = data_base.Srch(query);
            MessageBox.Show("ok1" + recrdtbl1.Rows.Count);

            if (recrdtbl1.Rows.Count > 0)
            {
                Count = 0;
                query = "";
                Count = Convert.ToInt32(recrdtbl1.Rows[0]["CountNo"].ToString());
                query = "";
                Count++;
                query = "update Customer_Cunt set CountNo=" + Count + " where CustomerID=" + Convert.ToInt32(customerID.Text.ToString()) + "";
                data_base.InsDelUpdt(query);


            }
            else
            {
                query = "insert into Customer_Cunt(CustomerID,CountNo)values(" + Convert.ToInt32(customerID.Text.ToString()) + ",1)";
                data_base.InsDelUpdt(query);

            }



        }

        private void rentalIssue_Click(object sender, EventArgs e)
        {
            // after checking that all text boxes are filled it will insert new record
            if (chkRental() == 1)
            {
             
                String query = "insert into Rental_Record(Customer_ID,Movie_ID,Rental_Date,Return_Date) values('" + customerID.Text.ToString() + "','" + movieID.Text.ToString() + "','" + Issue.Value.Date.ToString() + "','Issued On Rent')";
                data_base.InsDelUpdt(query);

                Video_Cunt();

                MessageBox.Show("Video is Issued on Rent ");
                query = "select * from Rental_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;


            }
            else
            {
                MessageBox.Show("Enter Proper Details");
            }
            err = 0;
            customerID.Text = "";
            movieID.Text = "";

        }

        private void rentalReturn_Click(object sender, EventArgs e)
        {
            //return the movie after double cliking in the data grid view and display the charges of the customer
            if (chkRental() == 1)
            {

                DataTable recordtbl = new DataTable();


                String query = "select * from Rental_Record where Rental_ID=" + Convert.ToInt32(RentalID.Text.ToString()) + "";
                recordtbl = data_base.Srch(query);


                if (recordtbl.Rows[0]["Return_Date"].ToString().Contains("Rent"))
                {

                    query = "select * from Video_Record where Video_ID=" + Convert.ToInt32(movieID.Text.ToString()) + "";
                    recordtbl = data_base.Srch(query);

                    Video_Cost = Convert.ToInt32(recordtbl.Rows[0]["Video_Cost"].ToString());



                    Video_Cost = rental_obj.rentalCost(Video_Cost, Issue.Value.ToString(), Return.Value.ToString());

                    query = "Update  Rental_Record set Customer_ID='" + customerID.Text.ToString() + "',Movie_ID='" + movieID.Text.ToString() + "',Rental_Date='" + Issue.Value.Date.ToString() + "',Return_Date='" + Return.Value.Date.ToString() + "' where Rental_ID=" + Convert.ToInt32(RentalID.Text.ToString()) + "";
                    data_base.InsDelUpdt(query);

                    MessageBox.Show("Video is returned and Charges is==$" + Video_Cost);

                    query = "select * from Rental_Record";
                    DataTable recordTbl = new DataTable();
                    recordTbl = data_base.Srch(query);
                    data.DataSource = recordTbl;


                }
                else
                {
                    MessageBox.Show("Video is already Returned");
                }




            }
            else
            {
                MessageBox.Show("Enter Proper Details");
            }
            err = 0;
            customerID.Text = "";
            movieID.Text = "";

        }

        private void rentalDelete_Click(object sender, EventArgs e)
        {
            // when movie is returned it cn be deleted from the datbase
            if (!RentalID.Text.ToString().Equals(""))
            {
                DataTable recordtbl = new DataTable();

              /*  String query = "select * from Rental_Record where Rental_ID=" + Convert.ToInt32(RentalID.Text.ToString()) + "";
                recordtbl = data_base.Srch(query);

                if (recordtbl.Rows[0]["Return_Date"].ToString().Contains("Rent"))
                {
                    MessageBox.Show("Video is Issued on Rent You Can't Delete the Record ");
                }
                else
                {*/
                    String query = "delete from Rental_Record where Rental_ID=" + Convert.ToInt32(RentalID.Text.ToString()) + "";
                    data_base.InsDelUpdt(query);
                    MessageBox.Show("Record Is Deleted");
                    query = "select * from Rental_Record";
                    DataTable recordTbl = new DataTable();
                    recordTbl = data_base.Srch(query);
                    data.DataSource = recordTbl;


               // }

            }
            customerID.Text = "";
            movieID.Text = "";

        }

        private void CustomerRatting_Click(object sender, EventArgs e)
        {
            // find the customer who get the video on rent top most
            String query = "select * from Customer_Cunt ORDER BY CountNo DESC";
            DataTable recrdTbl = data_base.Srch(query);
            MessageBox.Show("Most Video Rented By Customer ID is==" + recrdTbl.Rows[0]["CustomerID"]);
        }

        private void data_DoubleClick(object sender, EventArgs e)
        {

            // all the data according to the click is generated on the grid view object
            try
            {
                if (MovID == 1)
                {
                    movieID.Text = data.CurrentRow.Cells[0].Value.ToString();
                    title.Text = data.CurrentRow.Cells[1].Value.ToString();
                    Ratting.Text = data.CurrentRow.Cells[2].Value.ToString();
                    Year.Text = data.CurrentRow.Cells[3].Value.ToString();
                    Cost.Text = data.CurrentRow.Cells[4].Value.ToString();

                    Video_Cost = Convert.ToInt32(data.CurrentRow.Cells[4].Value.ToString());

                    Copies.Text = data.CurrentRow.Cells[5].Value.ToString();
                    Plot.Text = data.CurrentRow.Cells[6].Value.ToString();
                    Genre.Text = data.CurrentRow.Cells[7].Value.ToString();

                    MovID = 0;
                    CustID = 0;
                    RentID = 0;

                }

                if (CustID == 1)
                {

                    customerID.Text = data.CurrentRow.Cells[0].Value.ToString();
                    FirstName.Text = data.CurrentRow.Cells[1].Value.ToString();
                    LastName.Text = data.CurrentRow.Cells[2].Value.ToString();
                    MobileNo.Text = data.CurrentRow.Cells[3].Value.ToString();
                    Address.Text = data.CurrentRow.Cells[4].Value.ToString();
                    CustID = 0;
                    MovID = 0;
                    CustID = 0;
                    RentID = 0;

                }

                if (RentID == 1)
                {
                    RentalID.Text = data.CurrentRow.Cells[0].Value.ToString();
                    customerID.Text = data.CurrentRow.Cells[1].Value.ToString();
                    movieID.Text = data.CurrentRow.Cells[2].Value.ToString();
                    Issue.Text = data.CurrentRow.Cells[3].Value.ToString();

                    RentID = 0;
                    MovID = 0;
                    CustID = 0;
                    RentID = 0;

                }

         
            }
            catch (Exception es)
            {

            }

        }

        
        private void Year_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //display the cost of the price of the video after adding the year of the video
                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(Year.Text.ToString());
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    Cost.Text = "2";
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    Cost.Text = "5";
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //it will colse the rental store application
        private void Exit_Click(object sender, EventArgs e)
        {
           
            Close();
        }


        // below functing is used to display video record in data grid view
        private void DataVideo_Click(object sender, EventArgs e)
        {
           
            MovID = 1;
            
            CustID = 0;
            RentID = 0;
            String query = "select * from Video_Record";
            DataTable recordTbl = new DataTable();
            recordTbl = data_base.Srch(query);
            data.DataSource = recordTbl;
        }

        // below functing is used to display customer record in data grid view
        private void dataCustomer_Click(object sender, EventArgs e)
        {
           
            CustID = 1;
            MovID = 0;
                       RentID = 0;
            String query = "select * from Customer_Record";
            DataTable recordTbl = new DataTable();
            recordTbl = data_base.Srch(query);
            data.DataSource = recordTbl;
        }


        // below functing is used to display rental record in data grid view
        private void DataRental_Click(object sender, EventArgs e)
        {
            
            RentID = 1;
            MovID = 0;
            CustID = 0;
            
            String query = "select * from Rental_Record";
            DataTable recordTbl = new DataTable();
            recordTbl = data_base.Srch(query);


            data.DataSource = recordTbl;
        }
    }
}

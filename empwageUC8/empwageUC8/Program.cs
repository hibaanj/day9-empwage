class UC8
{
    const int FULLTIME = 1;
    const int PARTTIME = 2;
    public static void Campanyswage(string company, int Maxhrs, int maxdays, int wageperhr)
    {
        //use looping
        int days = 0;
        int hrs = 0;
        int wage = 0;
        int wagemonth = 0;
        int emphr = 0;

        while (hrs < Maxhrs && days < maxdays)
        {

            days++;

            Random r = new Random();
            int check = r.Next(0, 3);


            switch (check)
            {
                case FULLTIME:
                    emphr = 12;
                    break;
                case PARTTIME:
                    emphr = 8;
                    break;
                default:
                    emphr = 0;
                    break;

            }
            hrs += emphr;






        }

        wage = hrs * wageperhr;

        wagemonth += wage;
        Console.WriteLine("the wage of the employee working in " + company +" is " +wagemonth );



    }
    public static void Main(string[] args)
    {
        Campanyswage("amazon", 90, 25, 5000);
        Campanyswage("microsoft", 85, 28, 8000);

    }
}

namespace class_test_1
{
    public static partial class PracticeClass
    {
        public class Full_Time_Employee : Employee
        {
            public int AnnalSalary { get; set; }

            public void AdiustSalary(int anount)
            {
                this.AnnalSalary += anount;
            }
        }
    }
}

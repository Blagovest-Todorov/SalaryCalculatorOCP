namespace Dev
{
    public abstract class BaseSalaryCalculator
    {
        protected BaseSalaryCalculator(DeveloperReport developerReport)
        {
            this.DeveloperReport = developerReport;
        }

        protected DeveloperReport DeveloperReport { get; private set; }

        public abstract double CalculateSalary();
    }
}


namespace StudentExercises{
    public class NSSPerson{
        public string firstName{get;set;}
        public string lastName{get;set;}
        public Cohort currentCohort { get; set; }
        private string slackHandle { get; set; }
        public string getSlackHandle()
        {
            return slackHandle;
        }
    }

}
namespace StudyListApi.Business
{
    public abstract class BizActionBase
    {
        public abstract void DoValidate();
        public abstract void DoAction();

        public void Execute()
        {
            this.DoValidate();
            this.DoAction();
        }
    }
}

using System;


namespace R5T.L0067
{
    public class ProjectFileOperator : IProjectFileOperator
    {
        #region Infrastructure

        public static IProjectFileOperator Instance { get; } = new ProjectFileOperator();


        private ProjectFileOperator()
        {
        }

        #endregion
    }
}

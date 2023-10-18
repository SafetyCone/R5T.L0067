using System;
using System.Threading.Tasks;
using System.Xml.Linq;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;
using R5T.T0132;
using R5T.T0172;


namespace R5T.L0067
{
    [FunctionalityMarker]
    public partial interface IProjectFileOperator : IFunctionalityMarker
    {
        private static F0020.IProjectFileOperator F0020_ProjectFileOperator => F0020.ProjectFileOperator.Instance;


        public IProjectSdkName Get_SdkName(IProjectFilePath projectFilePath)
        {
            var output = F0020_ProjectFileOperator.GetSdk(projectFilePath.Value)
                .ToProjectSdkName();

            return output;
        }

        public Task<TOutput> In_QueryProjectFileContext<TOutput>(
            IProjectFilePath projectFilePath,
            Func<XElement, TOutput> function)
        {
            return F0020_ProjectFileOperator.InQueryProjectFileContext(
                projectFilePath.Value,
                function);
        }

        public TOutput In_QueryProjectFileContext_Synchronous<TOutput>(
            IProjectFilePath projectFilePath,
            Func<XElement, TOutput> function)
        {
            var output = F0020_ProjectFileOperator.InQueryProjectFileContext_Synchronous(
                projectFilePath.Value,
                function);

            return output;
        }
    }
}

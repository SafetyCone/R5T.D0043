using System;

using R5T.D0042.Stagira;
using R5T.T0010;
using R5T.T0064;


namespace R5T.D0043.Default
{
    [ServiceImplementationMarker]
    public class RemoteRepositoryUrlsListTextFileSerializer : TypedStringsListTextFileSerializerBase<RemoteRepositoryUrlsList, RemoteRepositoryUrl>,
        IRemoteRepositoryUrlsListTextFileSerializer,
        IServiceImplementation
    {
        protected override Func<string, RemoteRepositoryUrl> TypedStringConstructor => RemoteRepositoryUrl.From;
    }
}

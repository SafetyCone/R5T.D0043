using System;
using System.Collections.Generic;

using R5T.D0042.Stagira;
using R5T.T0010;


namespace R5T.D0043.Default
{
    public class RemoteRepositoryUrlsListTextFileSerializer : TypedStringsListTextFileSerializerBase<RemoteRepositoryUrlsList, RemoteRepositoryUrl>,
        IRemoteRepositoryUrlsListTextFileSerializer
    {
        protected override Func<string, RemoteRepositoryUrl> TypedStringConstructor => RemoteRepositoryUrl.From;
    }
}

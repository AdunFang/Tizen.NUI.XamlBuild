using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Tizen.NUI.XamlBinding.Internals;

namespace Tizen.NUI.XamlBinding
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal interface IPlatformServices
    {
        bool IsInvokeRequired { get; }

        void BeginInvokeOnMainThread(Action action);

        Ticker CreateTicker();

        Assembly[] GetAssemblies();

        string GetMD5Hash(string input);

        // double GetNamedSize(NamedSize size, Type targetElementType, bool useOldSizes);

        Task<Stream> GetStreamAsync(Uri uri, CancellationToken cancellationToken);

        // IIsolatedStorageFile GetUserStoreForApplication();

        // void OpenUriAction(Uri uri);

        void StartTimer(TimeSpan interval, Func<bool> callback);

        string RuntimePlatform { get; }

        void QuitApplication();
    }
}

using System;
namespace Contract
{
    interface ICommand
    {
        System.Collections.Generic.List<int> FileIds { get; set; }
        string ServiceName { get; set; }
        int UserRequestingDownloadId { get; set; }
        string ZipPackageName { get; set; }
    }
}

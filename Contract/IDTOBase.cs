using System;
namespace Contract
{
    interface IDTOBase
    {
        System.IO.Stream FileByteStream { get; set; }
        string FileName { get; set; }
        int Id { get; set; }
        long Length { get; set; }
    }
}

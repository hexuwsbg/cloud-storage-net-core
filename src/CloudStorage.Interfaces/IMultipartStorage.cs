using CloudStorage.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudStorage.Interfaces
{
    /// <summary>
    /// Interface providing access to big object storage.
    /// </summary>
    public interface IMultipartStorage
    {
        /// <summary>
        ///  初始化多段上传
        /// </summary>
        /// <param name="request">InitiateMultipartUploadRequest</param>
        /// <returns>InitiateMultipartUploadResponse</returns>
        InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request);

        /// <summary>
        /// 分段上传
        /// </summary>
        /// <param name="request">UploadPartRequest</param>
        /// <returns>UploadPartResponse</returns>
        UploadPartResponse UploadPart(UploadPartRequest request);

        /// <summary>
        /// 完成分段上传
        /// </summary>
        /// <param name="request">CompleteMultipartUploadRequest</param>
        /// <returns>CompleteMultipartUploadResponse</returns>
        CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request);

        /// <summary>
        /// 终止分段上传
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request);
    }
}

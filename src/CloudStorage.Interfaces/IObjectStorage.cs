using CloudStorage.Model;
using System;
using System.Threading.Tasks;

namespace CloudStorage.Interfaces
{
    /// <summary>
    /// Interface providing access to object storage.
    /// better limit the size of the object to 5M.
    /// </summary>
    public interface IObjectStorage
    {
        /// <summary>
        /// 存储对象
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>PutObjectResponse</returns>
        PutObjectResponse PutObject(PutObjectRequest request);

        /// <summary>
        /// 复制对象
        /// 用户有源文件的读写权限。
        /// 不支持跨地域拷贝。例如，不支持将杭州存储空间里的文件拷贝到青岛。
        /// 文件的大小不能超过1GB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CopyObjectResponse CopyObject(CopyObjectRequest request);

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>GetObjectResponse</returns>
        GetObjectResponse GetObject(GetObjectRequest request);

        /// <summary>
        /// 删除对象
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>DeleteObjectResponse</returns>
        DeleteObjectResponse DeleteObject(DeleteObjectRequest request);

        /// <summary>
        /// 判断对象是否存在
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>bool</returns>
        bool DoesObjectExist(ObjectExistRequest request);

        /// <summary>
        /// 生成预签名的获取对象链接
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GeneratePresignedGetUrlResponse GeneratePresignedGetUrl(GeneratePresignedGetUrlRequest request);
    }
}

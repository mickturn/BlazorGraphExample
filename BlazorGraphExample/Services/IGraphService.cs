﻿using BlazorGraphExample.Services.GraphAPI;
using System.Threading.Tasks;

namespace BlazorGraphExample.Services
{
    public interface IGraphService
    {
        Task<GraphUser> GetMeAsync();
        Task<Drive[]> GetDrivesAsync();
        Task<Drive> GetDriveAsync(string driveId);
        Task<DriveItem[]> GetDriveRootItemsAsync(string driveId = null);
    }
}
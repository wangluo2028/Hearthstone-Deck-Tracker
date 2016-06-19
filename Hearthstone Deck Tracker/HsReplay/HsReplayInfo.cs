﻿namespace Hearthstone_Deck_Tracker.HsReplay
{
	public class HsReplayInfo
	{
		public HsReplayInfo()
		{
			
		}

		public HsReplayInfo(string uploadId)
		{
			UploadId = uploadId;
		}

		public string UploadId { get; set; }

		public int UploadTries { get; set; }

		public bool Uploaded => !string.IsNullOrEmpty(UploadId);

		public string Url => $"{Constants.BaseUrl}/uploads/upload/{UploadId}";

		public void UploadTry() => UploadTries++;
	}
}

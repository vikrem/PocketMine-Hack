using System;
using System.Security.Cryptography;
using System.Text;

namespace PocketMineHasher
{
	class MainClass
	{
		private static string secret = "4kJp3rhBTdeFVozf+R00RhGI6UEuQREKGL02glRgnJrUB7F1zUVxwyG4yU+79fBG";

		public static void Main (string[] args)
		{
			Console.WriteLine (ComputeHash ("{\"ProfileHash\":\"ZlluF2diZajAAb28qwcazA==\", \"_gameStartedCount\":3, \"TutorialManager\":\"{\\\"firstChest\\\":\\\"active\\\", \\\"newBlockGrenade\\\":\\\"unactivated\\\", \\\"firstArtifact\\\":\\\"active\\\", \\\"newBlockBomb\\\":\\\"complete\\\", \\\"firstFusion\\\":\\\"unactivated\\\", \\\"firstGame\\\":\\\"complete\\\", \\\"newBlockDrill\\\":\\\"unactivated\\\", \\\"firstTradeCenter\\\":\\\"active\\\", \\\"firstSocial\\\":\\\"unactivated\\\", \\\"newBlockHeal\\\":\\\"unactivated\\\", \\\"newBlockGas\\\":\\\"unactivated\\\", \\\"firstCard\\\":\\\"active\\\", \\\"firstPickUpgrade\\\":\\\"active\\\", \\\"firstTradeArtifact\\\":\\\"active\\\", \\\"newBlockDynamite\\\":\\\"complete\\\"}\", \"RateAttemptCount\":4, \"BackendCredentials\":\"{\\\"Rpwd\\\":\\\"Jjlv3i0qoswOfzOfhhg/ontyUo0=\\\", \\\"Rid\\\":\\\"5528023348543488\\\"}\", \"ERT2CarNewlyUnlockedStatus\":\"{}\", \"_musicVolume\":0, \"_totalAdsWatched\":1, \"_useNotifications\":1, \"LootInventory\":\"{\\\"NewItemIds\\\":[\\\"woodChest\\\", \\\"coalOre\\\", \\\"ironOre\\\", \\\"ruby\\\"], \\\"Data\\\":[{\\\"LootItemID\\\":\\\"life\\\", \\\"Amount\\\":5}, {\\\"LootItemID\\\":\\\"dirtBlock\\\", \\\"Amount\\\":40}, {\\\"LootItemID\\\":\\\"rockBlock\\\", \\\"Amount\\\":3}, {\\\"LootItemID\\\":\\\"crateBlock\\\", \\\"Amount\\\":1}, {\\\"LootItemID\\\":\\\"goldOre\\\", \\\"Amount\\\":8}, {\\\"LootItemID\\\":\\\"diamondOre\\\", \\\"Amount\\\":1}, {\\\"LootItemID\\\":\\\"gem12\\\", \\\"Amount\\\":1}, {\\\"LootItemID\\\":\\\"cash\\\", \\\"Amount\\\":112}, {\\\"LootItemID\\\":\\\"videoToken\\\", \\\"Amount\\\":0}, {\\\"LootItemID\\\":\\\"woodChest\\\", \\\"Amount\\\":1}, {\\\"LootItemID\\\":\\\"coalOre\\\", \\\"Amount\\\":5}, {\\\"LootItemID\\\":\\\"ironOre\\\", \\\"Amount\\\":2}, {\\\"LootItemID\\\":\\\"ruby\\\", \\\"Amount\\\":9999}]}\", \"CheckFlurryReward\":0, \"BoosterCardProfile\":\"{\\\"Inventory\\\":[{\\\"Level\\\":1, \\\"ID\\\":\\\"DISTRIBUTION_BOMB\\\"}, {\\\"Level\\\":1, \\\"ID\\\":\\\"DISTRIBUTION_COAL\\\"}, {\\\"Level\\\":1, \\\"ID\\\":\\\"DISTRIBUTION_DYNAMITE\\\"}], \\\"NewCardIds\\\":[\\\"DISTRIBUTION_BOMB\\\", \\\"DISTRIBUTION_COAL\\\", \\\"DISTRIBUTION_DYNAMITE\\\"]}\", \"PublicID\":\"krju3827\", \"EnergyRemainingSeconds\":813, \"LocalLeaderboards\":\"{\\\"mostCoal\\\":5, \\\"deepest\\\":42, \\\"mostCash\\\":71, \\\"mostIron\\\":2}\", \"_facebookLikeRewardCollected\":0, \"_currentLanguage\":0, \"_soundsVolume\":1, \"_interstitialEnabled\":1, \"_gameSessionCount\":2, \"XP\":155, \"EnergySuspendDate\":\"11/05/2013 01:48:47\", \"HasRatedGame\":0, \"MessageCache\":\"{\\\"MessageList\\\":[]}\"}"));
		}
		//
		// Static Methods
		// This code was taken directly from Security:: in Assembly-CSharp.dll found in pocketmine.apk/assets/data/Managed/...
		// That dll was disassembled with monodis
		public static string ComputeHash (string message)
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding ();
			byte[] bytes = uTF8Encoding.GetBytes (secret);
			HMACSHA1 hMACSHA = new HMACSHA1 (bytes);
			byte[] bytes2 = uTF8Encoding.GetBytes (message);
			byte[] array = hMACSHA.ComputeHash (bytes2);
			return Convert.ToBase64String (array);
		}
	}
}

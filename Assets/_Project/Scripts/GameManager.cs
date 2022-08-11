using System.Numerics;
using MoralisUnity;
using MoralisUnity.Web3Api.Models;
using Nethereum.Util;
using TMPro;
using UnityEngine;

namespace Cronos_Hackathon_Starter_Sample
{
    public class GameManager : MonoBehaviour
    {
        [Header("Main Components")]
        public PlayerController player;

        [Header("UI")]
        public TextMeshProUGUI balanceLabel;
    
        public async void StartGame()
        {
            player.input.EnableInput(true);
            player.walletAddress.Activate();

            // Get native balance
            NativeBalance nativeBalance = await Web3Tools.GetNativeBalance();
            
            // Convert it to number
            var integerBalance = BigInteger.Parse(nativeBalance.Balance);
            
            // Convert wei to native
            var formattedBalance = UnitConversion.Convert.FromWei(integerBalance);

            balanceLabel.text = formattedBalance.ToString();
        }
    }   
}

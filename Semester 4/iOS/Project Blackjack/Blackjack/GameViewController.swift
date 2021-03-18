//
//  GameViewController.swift
//  Blackjack
//
//  Created by Marshall Radziwilko on 2021-03-13.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit

class GameViewController: UIViewController {
    
    
    // Outlets
    @IBOutlet weak var PlayerName: UILabel!
    @IBOutlet weak var plrCoins: UILabel!
    @IBOutlet weak var pCard1: UIImageView!
    @IBOutlet weak var pCard2: UIImageView!
    @IBOutlet weak var pCard3: UIImageView!
    @IBOutlet weak var pCard4: UIImageView!
    @IBOutlet weak var pCard5: UIImageView!
    @IBOutlet weak var pCard6: UIImageView!
    @IBOutlet weak var pCard7: UIImageView!
    @IBOutlet weak var dCard1: UIImageView!
    @IBOutlet weak var dCard2: UIImageView!
    @IBOutlet weak var dCard3: UIImageView!
    @IBOutlet weak var dCard4: UIImageView!
    @IBOutlet weak var dCard5: UIImageView!
    @IBOutlet weak var dCard6: UIImageView!
    @IBOutlet weak var dCard7: UIImageView!
    @IBOutlet weak var dScore: UILabel!
    @IBOutlet weak var pScore: UILabel!
    @IBOutlet weak var btnStand: UIButton!
    @IBOutlet weak var btnHit: UIButton!
    @IBOutlet weak var btnPlayAgain: UIButton!
    @IBOutlet weak var btnEndGame: UIButton!
    
    // Play Card 2D Arrays
    var playerCards = [[Any]]()
    var dealerCards = [[Any]]()
    
    // Player Score Overall of hand
    var playerScore: Int = 0;
    var dealerScore: Int = 0;

    // Prefrence Values.
    let Player = Configuration.value(defaultValue: "NoPlayer", forKey: "playername")
    var Coins = Configuration.value(defaultValue: 500, forKey: "coins")

    
    override func viewDidLoad() {
        super.viewDidLoad()
    }
    
    
    // Everytime the View is loaded/Returned to Reload Hand.
    override func viewDidAppear(_ animated: Bool) {

       SetResetBoard()
        
        PlayerName.text = (Player)
        plrCoins.text =  "$" + String(Coins)
        // Add 2 To Player
        playerCards.append([randCard(), randomString(length: 1)])
        playerCards.append([randCard(), randomString(length: 1)])
        
        
        // Add 2 to Dealer
        dealerCards.append([randCard(), randomString(length: 1)])
        dealerCards.append([randCard(), randomString(length: 1)])
        // Display Dealer / Player Cards
        DisplayDlrBaseCards()
        DisplayCards()
        
    }
    
    
    // Hit Button
    @IBAction func pHit(_ sender: Any) {
        playerCards.append([randCard(), randomString(length: 1)])
        DisplayCards()
    }
    
    
    // Stand Button
    @IBAction func pStand(_ sender: Any) {
        
        btnHit.isHidden = true
        btnStand.isHidden = true
        
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
        DlrPlay()
        dScore.isHidden = false
    }
    
    
    
    // Play Hand of Dealer untill Deal is Equal, Above Player but below 21, or Busted
    func DlrPlay() -> Void {
        
        while (dealerScore < playerScore) {
            // Add Card
            dealerCards.append([randCard(), randomString(length: 1)])
            // Display / Calculate hand
            DisplayDlrCards()
            
        }
        
    }
    
    // Start new Hand
    @IBAction func pRetry(_ sender: Any) {
        SetResetBoard()
        // Add 2 To Player
        playerCards.append([randCard(), randomString(length: 1)])
        playerCards.append([randCard(), randomString(length: 1)])
        
        
        // Add 2 to Dealer
        dealerCards.append([randCard(), randomString(length: 1)])
        dealerCards.append([randCard(), randomString(length: 1)])
        // Display Dealer / Player Cards
        DisplayDlrBaseCards()
        DisplayCards()
        
    }
    // End Game, Reset Board, Go back to title screen
    @IBAction func pEnd(_ sender: Any) {
        SetResetBoard()
        self.tabBarController?.selectedIndex = 0
    }
    
    
    // Dispay Player Cards
    func DisplayCards() -> Void {
        
        // Local Variables
        var CardID: Int;
        var CardFace: String;
        var CardSlot: Int = 0;
        var CardValues: Int = 0;
        
        // Set Score of Player to 0 To make no overwrites
        playerScore = 0
        
        // Do this for each item in array.
        for i in 0..<playerCards.count { // 4th row
            CardID = playerCards[i][0] as! Int
            CardFace = playerCards[i][1] as! String
            print(String(CardID) + " " + CardFace)
            CardValues = CardValues + retValue(cardID: CardID, CurVal: CardValues)
            CardSlot = CardSlot + 1
            SetCard(CardNum: CardID, CardSuit: CardFace, CardSlot: CardSlot, PlrOrDlr: true)
        }
        // Set Global Score
        playerScore = CardValues
        
        
        // Check if busted set lose if over 21
        if(CardValues > 21) {
            SetLose()
        }
        
        // Show Player Score
        pScore.text = String(CardValues)
       // Print to console Value for logging
        print(String(CardValues) )
    }
    
    
    // Initial Display of Dealer hand, does not Calculate if Busted or win.
    func DisplayDlrBaseCards() -> Void {
        var CardID: Int;
        var CardFace: String;
        var CardSlot: Int = 0;
        var CardValues: Int = 0;

      dealerScore = 0
        for i in 0..<dealerCards.count { // 4th row
            CardID = dealerCards[i][0] as! Int
            CardFace = dealerCards[i][1] as! String
            print(String(CardID) + " " + CardFace)
            CardValues = CardValues + retValue(cardID: CardID, CurVal: CardValues)
            CardSlot = CardSlot + 1
            SetCard(CardNum: CardID, CardSuit: CardFace, CardSlot: CardSlot, PlrOrDlr: false)
        }
        
        dealerScore = CardValues
        dScore.text = String(CardValues)
        print(String(CardValues) )
    }
    
    
    // Function after play hit's stand, Dealer will play untill Dealer is Equal, Over Player but below 21, or Busted (over 21)
    // Same as Player hand just for Dealer.
    func DisplayDlrCards() -> Void {
        var CardID: Int;
        var CardFace: String;
        var CardSlot: Int = 0;
        var CardValues: Int = 0;

        dealerScore = 0
        for i in 0..<dealerCards.count { // 4th row
            CardID = dealerCards[i][0] as! Int
            CardFace = dealerCards[i][1] as! String
            print(String(CardID) + " " + CardFace)
            CardValues = CardValues + retValue(cardID: CardID, CurVal: CardValues)
            CardSlot = CardSlot + 1
            SetCard(CardNum: CardID, CardSuit: CardFace, CardSlot: CardSlot, PlrOrDlr: false)
            dealerScore = CardValues
        }
        
        if(CardValues > 21) {
            SetDlrLose()
            
        }else if(CardValues == playerScore) {
            SetTie()
            
        }else if(dealerScore > playerScore && dealerScore < 22) {
            SetDlrWin()
        }
        
        dScore.text = String(CardValues)
        
        print(String(CardValues) )
        
        
    }
    
    
    
    // Set Card Images on Board, The Function has,  1: Card Number (1-13) 2: CardSuit H: Hearts, C: Clubs, D:Diamons, S:Spaids, 3: Position on Hand 1-7, 4: Player = true, Dealer = False
    func SetCard(CardNum: Int, CardSuit: String, CardSlot: Int, PlrOrDlr: Bool) -> Void{
        var CardImgID: String;
        
        CardImgID = CardSuit + String(CardNum)
        // Player = True or Dealer = False
        if(PlrOrDlr == true) {
            switch (CardSlot) {
                case 1:
                    pCard1.image = UIImage(named:CardImgID)
                break;
                case 2:
                    pCard2.image = UIImage(named:CardImgID)
                break;
                case 3:
                    pCard3.image = UIImage(named:CardImgID)
                break;
                case 4:
                    pCard4.image = UIImage(named:CardImgID)
                break;
                case 5:
                    pCard5.image = UIImage(named:CardImgID)
                break;
                case 6:
                    pCard6.image = UIImage(named:CardImgID)
                break;
                case 7:
                    pCard7.image = UIImage(named:CardImgID)
                break;
                default:
                    dCard7.image = UIImage(named:"standard")
                break;
            }
        }else{

            switch (CardSlot) {
                case 1:
                    dCard1.image = UIImage(named:CardImgID)
                break;
                case 2:
                    dCard2.image = UIImage(named:CardImgID)
                break;
                case 3:
                    dCard3.image = UIImage(named:CardImgID)
                break;
                case 4:
                    dCard4.image = UIImage(named:CardImgID)
                break;
                case 5:
                    dCard5.image = UIImage(named:CardImgID)
                break;
                case 6:
                    dCard6.image = UIImage(named:CardImgID)
                break;
                case 7:
                    dCard7.image = UIImage(named:CardImgID)
                break;
                default:
                    dCard7.image = UIImage(named:"dealerback")
                break;
            }
        }
        
    }
    
    
    // Set Player Win Hide HIT,Stand, show Retry and Quit
    func SetWin() -> Void{
        
        print("Player Win!")
        showInputDialog(true, inftitle: "Player Wins", infmessage: "Player has Won.")
        btnHit.isHidden = true
        btnStand.isHidden = true
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
        Coins = Coins + 5
        
        Configuration.value(value: Coins, forKey: "coins")
        plrCoins.text =  "$" + String(Coins)
        
        
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
        
    }
    
    
    // Set Player Tie Hide HIT,Stand, show Retry and Quit
    func SetTie() -> Void{
        
        print("Game Tied!")
        showInputDialog(true, inftitle: "Game Tied", infmessage: "Game was a Tie.")
        btnHit.isHidden = true
        btnStand.isHidden = true
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
        
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
    }
    
    // Set Player Busted/Lose Hide HIT,Stand, show Retry and Quit
    func SetLose() -> Void{

        print("Player Busted!")
        showInputDialog(true, inftitle: "Dealer Wins", infmessage: "Player has busted.")
        btnHit.isHidden = true
        btnStand.isHidden = true
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
        Coins = Coins - 5
        
        Configuration.value(value: Coins, forKey: "coins")
        plrCoins.text =  "$" + String(Coins)
        
        
        
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
        
    }
    
    // Set Dealer Lose Hide HIT,Stand, show Retry and Quit
    func SetDlrLose() -> Void{

        print("Dealer Busted!")
        showInputDialog(true, inftitle: "Player Wins", infmessage: "Dealer has busted.")
        
        btnHit.isHidden = true
        btnStand.isHidden = true
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
        Coins = Coins + 5
        
        Configuration.value(value: Coins, forKey: "coins")
        plrCoins.text =  "$" + String(Coins)
        
        
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
        
    }
    
    
    // Set Dealer Win Hide HIT,Stand, show Retry and Quit
    func SetDlrWin() -> Void{

        print("Dealer Wins!")
        
        showInputDialog(true, inftitle: "Dealer Wins", infmessage: "Dealer has Won.")
        btnHit.isHidden = true
        btnStand.isHidden = true
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
        Coins = Coins - 5
        
        Configuration.value(value: Coins, forKey: "coins")
        plrCoins.text =  "$" + String(Coins)
        
        
        btnEndGame.isHidden = false
        btnPlayAgain.isHidden = false
        
    }
    
    
    // Dialog for Win/Lose Information Confirmation
    func showInputDialog(_ animated: Bool, inftitle: String, infmessage: String) {
              let alert = UIAlertController(title: inftitle, message: infmessage, preferredStyle: .alert)
              alert.addAction(UIAlertAction(title: NSLocalizedString("OK", comment: "Default action"), style: .default, handler: { _ in
             
              }))
              self.present(alert, animated: true, completion: nil)
          }
    
    
    // Reset Board to default, set scores to 0, remove Cards, Set Card Backs, set Text, Show/Hide Proper buttons
    func SetResetBoard() -> Void{
        
        btnHit.isHidden = false
        btnStand.isHidden = false
        btnEndGame.isHidden = true
        btnPlayAgain.isHidden = true
        playerCards.removeAll()
        dealerCards.removeAll()
        playerScore = 0
        dealerScore = 0
        dScore.text = "0"
        pScore.text = "0"
        
        dScore.isHidden = true
        dCard1.image = UIImage(named:"dealerback")
        dCard2.image = UIImage(named:"dealerback")
        dCard3.image = UIImage(named:"dealerback")
        dCard4.image = UIImage(named:"dealerback")
        dCard5.image = UIImage(named:"dealerback")
        dCard6.image = UIImage(named:"dealerback")
        dCard7.image = UIImage(named:"dealerback")
        
        pCard1.image = UIImage(named:"standard")
        pCard2.image = UIImage(named:"standard")
        pCard3.image = UIImage(named:"standard")
        pCard4.image = UIImage(named:"standard")
        pCard5.image = UIImage(named:"standard")
        pCard6.image = UIImage(named:"standard")
        pCard7.image = UIImage(named:"standard")
    }
    
    // Return Value of Card, as we know 1 = Ace, 2 - 10, and J/Q/K = 10
    func retValue(cardID: Int, CurVal: Int) -> Int {
        
        var CarvValRet: Int;
        
        if(cardID == 1) {
            CarvValRet = 1
        }else if(cardID == 11 || cardID == 12 || cardID == 13 ) {
            CarvValRet = 10
        }else {
            CarvValRet = cardID           
        }
        return CarvValRet
    }
    
    
    // Return Value for Card Number 1 - 13 (Easier then 52 cards and finding every 13th card.
    func randCard() -> Int {
        let randnum = Int.random(in: 1..<13)
        return randnum
    }
    
    // Return random Value for Face Suit, C=Clubs, H=Hearts, S=Spaids, D=Diamonds
    func randomString(length: Int) -> String {
      let letters = "CHDS"
      return String((0..<length).map{ _ in letters.randomElement()! })
    }
    
    
    
}

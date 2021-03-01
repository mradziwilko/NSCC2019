package Database;


import java.sql.Connection;  
import java.sql.DriverManager;  
import java.sql.PreparedStatement;
import java.sql.SQLException;

import Properties.GameProperties;

public class Update { 
   
    public static Connection connect() {  
        // SQLite connection string  
        String url = "jdbc:sqlite:"+ GameProperties.GAME_PATH +"/MazeServer.db";  
        Connection conn = null;  
        try {  
            conn = DriverManager.getConnection(url);  
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }  
        return conn;  
    }  
   



    public static void UpdateName(String name){     	
 	 
   	 
   	 String sql = "UPDATE players SET name = ? WHERE id = 1"; 
          
        try {  
            Connection conn = connect();  
            PreparedStatement pstmt = conn.prepareStatement(sql);  
            pstmt.setString(1, name);
            System.out.println("Updated: Player Name, "+ name +".");
            pstmt.executeUpdate();                
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }  
    } 



    public  void UpdateDeath(int id){     	
 	 
   	 
   	 String sql = "UPDATE players SET deaths = deaths + 1 WHERE id = ?"; 
          
        try {  
            Connection conn = connect();  
            PreparedStatement pstmt = conn.prepareStatement(sql);  
            pstmt.setInt(1, id);
            pstmt.executeUpdate();                
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }  
    } 
    
    public  void UpdateWin(int id){     	
    	 
      	 
      	 String sql = "UPDATE players SET wins = wins + 1 WHERE id = ?"; 
             
           try {  
               Connection conn = connect();  
               PreparedStatement pstmt = conn.prepareStatement(sql);  
               pstmt.setInt(1, id);
               pstmt.executeUpdate();                
           } catch (SQLException e) {  
               System.out.println(e.getMessage());  
           }  
       } 
    	
    	
   
}  
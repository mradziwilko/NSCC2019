package Database;


import java.sql.Connection;  
import java.sql.DriverManager;  
import java.sql.PreparedStatement;
import java.sql.SQLException;

import Properties.GameProperties;

public class Update { 
   
    public static Connection connect() {  
        // SQLite connection string  
        String url = "jdbc:sqlite:"+ GameProperties.GAME_PATH +"/themaze.db";  
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
            pstmt.executeUpdate();                
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }  
    } 


    public static void UpdateSID(int sid){     	
 	 
   	 
   	 String sql = "UPDATE players SET gameid = ? WHERE id = 1"; 
          
        try {  
            Connection conn = connect();  
            PreparedStatement pstmt = conn.prepareStatement(sql);  
            pstmt.setInt(1, sid);
            pstmt.executeUpdate();                
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }  
    } 


    public static void ClearUser(){  
    	
   	 
   	 String sql = "UPDATE players SET  gameid = ?, name = ? WHERE id = 1"; 
          
        try {  
            Connection conn = connect();  
            PreparedStatement pstmt = conn.prepareStatement(sql);
            pstmt.setInt(1, 0);
            pstmt.setString(2, null);
            pstmt.executeUpdate();                
           
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }  
    } 
   
   
}  
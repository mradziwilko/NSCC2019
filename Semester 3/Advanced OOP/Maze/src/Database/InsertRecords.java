package Database;

import java.sql.Connection;  
import java.sql.DriverManager;  
import java.sql.PreparedStatement;  
import java.sql.SQLException;

import Properties.GameProperties;  
   
public class InsertRecords {  
   
    private Connection connect() {  
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
   
  
    public void insert(int id, int inpCID, String inpname) {  
        String sql = "INSERT INTO players(id, gameid, name) VALUES(?,?,?)";  

        System.out.println(inpname); 
        try{  
            Connection conn = this.connect();  
            PreparedStatement pstmt = conn.prepareStatement(sql);  
            pstmt.setInt(1, id);     
            pstmt.setInt(2, inpCID); 
            pstmt.setString(3, inpname);;  
            pstmt.executeUpdate();  
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }  
    }  

   
   
}  
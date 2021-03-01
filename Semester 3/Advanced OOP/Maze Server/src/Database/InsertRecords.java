package Database;

import java.sql.Connection;  
import java.sql.DriverManager;  
import java.sql.PreparedStatement;  
import java.sql.SQLException;

import Properties.GameProperties;  
   
public class InsertRecords {  
   
    private Connection connect() {  
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
   
   

    public void addUser(String inpname) {  
        String sql = "INSERT INTO players(id, name, wins, deaths) VALUES(NULL,?,0,0)";  

        System.out.println(inpname); 
        try{  
            Connection conn = this.connect();  
            PreparedStatement pstmt = conn.prepareStatement(sql); 
            pstmt.setString(1, inpname);  
            pstmt.executeUpdate();  
        } catch (SQLException e) {  
            System.out.println(e.getMessage()+ "IS HERE");  
        }  
    }  
}  
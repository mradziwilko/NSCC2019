package Database;
import java.sql.DriverManager;
import java.sql.Connection;  
import java.sql.ResultSet;  
import java.sql.SQLException;  
import java.sql.Statement;

import Properties.GameProperties;  
   
public class SelectRecords {  
   
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
   

    public void selectAll(){  
        String sql = "SELECT * FROM players";  
          
        try {  
            Connection conn = this.connect();  
            Statement stmt  = conn.createStatement();  
            ResultSet rs    = stmt.executeQuery(sql);  
              
            // loop through the result set  
            while (rs.next()) {  
                System.out.println(rs.getInt("id") +  "\t" +   
                                   rs.getString("name") + "\t" +  
                                   rs.getDouble("capacity"));  
            }  
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }  
    }  




    public String selectName(){   
        String sql = "SELECT id, name FROM players WHERE id = 1";
        String name = "";
        
        try {  
            Connection conn = this.connect();  
            Statement stmt  = conn.createStatement();  
            ResultSet rs    = stmt.executeQuery(sql);  


            // loop through the result set  
            while (rs.next()) {  
                
                                 name = rs.getString("name");  
            }  
            
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }
		return name;  
    }  



    public int selectSID(){   
        String sql = "SELECT id, gameid FROM players WHERE id = 1";
        int gid = 0;
        
        try {  
            Connection conn = this.connect();  
            Statement stmt  = conn.createStatement();  
            ResultSet rs    = stmt.executeQuery(sql);  


            // loop through the result set  
            while (rs.next()) {  
            	gid = rs.getInt("gameid");  
            }  
            
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }
		return gid;  
    }  


   
}  
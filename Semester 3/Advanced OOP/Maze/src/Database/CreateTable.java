package Database;

import java.sql.Connection;
import java.sql.DatabaseMetaData;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;  
import java.sql.Statement;


import Properties.GameProperties;  
   
public class CreateTable {  

    
    @SuppressWarnings("unused")
	private static Connection connect() {  
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
   
    
    public static void createNewTable() {
    	
    	
        // SQLite connection string  
        String url = "jdbc:sqlite:"+ GameProperties.GAME_PATH +"/themaze.db";  
          
        // SQL statement for creating a new table  
        String sql = "CREATE TABLE IF NOT EXISTS players (\n"  
                + " id int PRIMARY KEY,\n" 
                + " gameid int NOT NULL, \n"    
                + " name text"  
                + ");";  
          
        try{  
            Connection conn = DriverManager.getConnection(url);  
            Statement stmt = conn.createStatement();  
            stmt.execute(sql);  
            System.out.println("Connection Created Table."); 
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }  
    }  
   
}  
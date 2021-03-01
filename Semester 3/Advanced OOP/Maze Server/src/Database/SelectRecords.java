package Database;
import java.sql.DriverManager;
import java.awt.Cursor;
import java.sql.Connection;  
import java.sql.ResultSet;  
import java.sql.SQLException;  
import java.sql.Statement;
import java.util.ArrayList;

import org.sqlite.SQLiteException;


import Properties.GameProperties;  
   
public class SelectRecords {  
   
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

    public String getName(int id){   
        String sql = "SELECT id, name FROM players WHERE id = "+id;
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



    public int getUserId(String name){   
        String sql = "SELECT * FROM players WHERE name = '"+ name +"'";
        int gid = 0;
        
        try {  
            Connection conn = this.connect();  
            Statement stmt  = conn.createStatement();  
            ResultSet rs    = stmt.executeQuery(sql);  


            // loop through the result set  
            while (rs.next()) {  
            	gid = rs.getInt("id");  
            }  
            
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }
		return gid;  
    }  


    public int getDeaths(int plrid){   
        String sql = "SELECT id, deaths FROM players WHERE id = "+ plrid +" LIMIT 1";
        int deaths = 0;
        
        try {  
            Connection conn = this.connect();  
            Statement stmt  = conn.createStatement();  
            ResultSet rs    = stmt.executeQuery(sql);  


            // loop through the result set  
            while (rs.next()) {  
            	deaths = rs.getInt("deaths");  
            }  
            
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }
		return deaths;  
    }  

    public int getWins(int plrid){   
        String sql = "SELECT id, wins FROM players WHERE id = "+ plrid +" LIMIT 1";
        int wins = 0;
        
        try {  
            Connection conn = this.connect();  
            Statement stmt  = conn.createStatement();  
            ResultSet rs    = stmt.executeQuery(sql);  


            // loop through the result set  
            while (rs.next()) {  
            	wins = rs.getInt("wins");  
            }  
            
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }
		return wins;  
    }  


	public String getTopTen() {
    	String sql = "SELECT id FROM players ORDER BY wins DESC LIMIT 10";

    	
        String rtlString = "";
		int id;
		
        String name;
        try {  
            Connection conn = this.connect();  
            Statement stmt  = conn.createStatement();  
            ResultSet rs    = stmt.executeQuery(sql);
            // loop through the result set  
            while (rs.next()) { 
            	
            	id = rs.getInt("id");
            	rtlString = rtlString + id+",";
            }  
            
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }

    	return rtlString;  
    	
    	
    }


	private String replace(String string, String string2) {
		// TODO Auto-generated method stub
		return null;
	}


	public int getTopWinCount(int id) {
        String sql = "SELECT id, wins FROM players WHERE id = "+ id +" LIMIT 1";

    	int wincount = 0;

        try {  
            Connection conn = this.connect();  
            Statement stmt  = conn.createStatement();  
            ResultSet rs    = stmt.executeQuery(sql);
            // loop through the result set  
            while (rs.next()) { 
            	
            	wincount = rs.getInt("wins");
            }  
            
        } catch (SQLException e) {  
            System.out.println(e.getMessage());  
        }

    	return wincount;  
    	
	}


	public String getTopName(int id) {
        String sql = "SELECT id, name FROM players WHERE id = "+ id +" LIMIT 1";

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
   
}  

package project01;

import com.mysql.jdbc.Connection;
//import com.mysql.jdbc.Statement;
import java.sql.DriverManager;
//import javax.swing.JOptionPane;
import java.util.logging.Level;
import java.util.logging.Logger;



public class Myconnection {
        //public Connection cn;
        //public Statement st;
    public static Connection getconnection(){
        Connection con=null;
     try{
            Class.forName("com.mysql.jdbc.Driver");
            con=(Connection) DriverManager.getConnection("jdbc:mysql://localhost:3306/registration?zeroDateTimeBehavior=convertToNull","root","");
            //st=(Statement) cn.createStatement();
            //JOptionPane.showMessageDialog(null,"connected");
        }
        catch(Exception ex){
            //JOptionPane.showMessageDialog(null,"not connected");
        System.out.println(ex.getMessage());
}
        return con;
        }

}
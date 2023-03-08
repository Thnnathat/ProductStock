
import mysql.connector
class Conn():
    def con():
        mydb = mysql.connector.connect(
        host="localhost",
        user="root",
        password="thnnathat",
        database="product_stock"
        )
        return mydb

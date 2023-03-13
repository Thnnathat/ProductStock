import ikea_api
import requests
from PIL import Image
import json
import os
from conn import Conn;
import time

def getIkeaData(keyword):
    constants = ikea_api.Constants(country="us", language="en")
    search = ikea_api.Search(constants)
    endpoint = search.search(keyword, limit=100)
    data = ikea_api.run(endpoint)
    return data

def getIkeaImage(url):
    im = Image.open(requests.get(url, stream=True).raw)
    image_name = url.lstrip("https://www.ikea.com/us/en/images/products/")
    rgb_img = im.convert("RGB")
    return rgb_img, image_name

def readImageBin(image_name):
        with open("./temp/"+image_name, 'rb') as image:
            return image.read()

def convertImageBinary(rgb_img, image_name):
    try:
        rgb_img.save("./temp/"+image_name)
        image = readImageBin(image_name)
        os.remove("./temp/"+image_name)
        return image
    except:
        return False;

def ikeaCleanData(product):
    products = []
    product = product["searchResultPage"]["products"]["main"]["items"]
    for i in product:
        temp = []
        prod_item = i["product"]
        temp.append(prod_item["id"])
        temp.append(prod_item["name"])
        temp.append(prod_item["typeName"])
        temp.append(prod_item["salesPrice"]["numeral"])
        color = prod_item["colors"]
        if (len(color) > 0):
            temp.append(prod_item["colors"][0])
        else :
            temp.append({"name": None, "id": "00000", "hex": "ffffff"})
        temp.append(prod_item["mainImageUrl"])
        temp.append("0")
        products.append(temp)
    return products


def inserDatabase(data):
    count = 1
    for i in data:
        conn = Conn.con();
        rgb_img, image_name = getIkeaImage(i[5]);
        image = convertImageBinary(rgb_img, image_name)
        if (image):
            pass
        else:
            image = readImageBin("image-gdc9f050a2_640.png") # default image.
        try:
            mycursor = conn.cursor()
            sql = "INSERT INTO products(id, name, type_name, price, color, color_hex, image, product_count) VALUES(%s,%s,%s,%s,%s,%s,%s,%s)"
            value = (i[0], i[1], i[2], i[3], i[4]["name"], "#"+i[4]["hex"], image, '0')
            mycursor.execute(sql, value)
            conn.commit()
            print(count)
            count += 1
        except Exception as e:
            print(e)
        conn.close();
        time.sleep(0.5)

if __name__ == "__main__":
    keyword = ["HEMNES", "ALEX", "FEJKA", "LIGHT"];
    for i in keyword:
        ikeaData = getIkeaData(i)
        data = ikeaCleanData(ikeaData)
        inserDatabase(data)
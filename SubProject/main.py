import ikea_api
import requests
from PIL import Image
import json
import os
from conn import Conn;


def getIkeaData():
    # Constants like country, language, base url
    constants = ikea_api.Constants(country="us", language="en")
    # Search API
    search = ikea_api.Search(constants)
    # Search endpoint with prepared data
    endpoint = search.search("ALEX", limit=5)
    data = ikea_api.run(endpoint)
    return data

def getIkeaImage():
    url = "https://www.ikea.com/us/en/images/products/alex-drawer-unit-white__0977775_pe813763_s5.jpg";
    im = Image.open(requests.get(url, stream=True).raw)
    image_name = url.lstrip("https://www.ikea.com/us/en/images/products/")
    rgb_im = im.convert("RGB")
    print(image_name)
    return rgb_im, image_name

def binary(filename):
    with open(filename, 'rb') as image:
        return image.read()

def saveImageBinary(filename):
    img_bin = binary(filename)
    f = open("myfile.bin", "x")
    f.write(img_bin)

def writeDataFile():
    f = open("./json/TEST.json", "a")
    f.write(json.dumps(data))
    f.close()

ikeaData = getIkeaData()
rgb_img, image_name = getIkeaImage();
image_name = "./temp/"+image_name
rgb_img.save(image_name)
image = binary(image_name)
os.remove(image_name)

def ikeaCleanData(product):
    product["searchResultPage"]["products"]["main"]["items"]
    
data = ikeaData(getIkeaData())
def inserDatabase(image):
    conn = Conn.con();
    try:
        mycursor = conn.cursor()
        sql = "INSERT INTO products(id, name, type_name, price, color, image, count) VALUES(%s,%s,%s,%s,%s,%s,%s)"
        value = ("1", "mr", "Thnnathat", "Chaiphutha", "admin", image)
        mycursor.execute(sql, value)
        conn.commit()
    except Exception as e:
        print(e)
    conn.close();

inserDatabase(image=image)
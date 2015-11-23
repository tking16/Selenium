require 'selenium-webdriver'

browse = Selenium::WebDriver.for :firefox

browse.get "http://amazon.co.uk"

search = browse.find_element name: "field-keywords"

search.send_keys "Eloquent Ruby"

search.submit

book = browse.find_element class: "a-color-price"

book.text

puts book.text
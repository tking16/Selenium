require 'selenium-webdriver'

browser = Selenium::WebDriver.for :firefox

browser.get "http://tumblr.com"

button = browser.find_element class: "login-button"

button.click

username = browser.find_element name: "user[email]"

username.send_keys "tking@spartaglobal.com"

pass = browser.find_element name: "user[password]"

pass.send_keys "******"

pass.submit

post = browser.find_element class: "icon_post_text"

post.click

title = browser.find_element class: "editor-plaintext"

title.send_keys "Tumblr Automation"

body = browser.find_element class: "editor-richtext"

body.click

body.send_keys "this is an automated tumblr post"

submit_post = browser.find_element class: "blue"

submit_post.click

view = browser.find_element class: "post_title"

puts "you have posted to your blog. the title of your post is #{view.text}"
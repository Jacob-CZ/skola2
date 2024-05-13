# Car rental project

## Features
 - postgress storage
 - storage bucket for car photo storage
 - runs on wasm
 - deployed on gh-pages
 - dynamic routes for the individual entities


## why is the code not DRY
 - it was dificult to abstract the funcitons because they need acces to the global supabase client and they are often very similar but not the same

## why supabase
- it is a back end as a service so the page can be static

## Is blazor any good
- I think its rubbish ( the only good thing is that it is strongely typed )
- But maybe i just havent discovered its magic 
- Is next js better?  yes (with type script)


## classes and methods 
 - there arent really any classes because of the nature of the supabase sdk
 - the only classes are the db models that bind the db tables and row with some public vairables
 - the models inherit from the base model that has some base methods like: 
   - update - this method takes the currnet values of the bound variables accept for the primary key and sync them with the db
   - delete - deletes the row bound to the object from the db 
- razr file methods
  - there are lot of utility methods to query and update the db and re render the site using state has changed (their functionalyty is described in the comment and their name)   
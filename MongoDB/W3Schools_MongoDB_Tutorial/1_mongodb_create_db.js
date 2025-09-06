// You can change or create a new database by typing use then the name of the database.

// Create a new database called "blog":
use blog


// MongoDB mongosh Insert

db.posts.insertOne({
  title: "Post Title 1",
  body: "Body of post.",
  category: "News",
  likes: 1,
  tags: ["news", "events"],
  date: Date()
})

db.posts.insertMany([  
  {
    title: "Post Title 2",
    body: "Body of post.",
    category: "Event",
    likes: 2,
    tags: ["news", "events"],
    date: Date()
  },
  {
    title: "Post Title 3",
    body: "Body of post.",
    category: "Technology",
    likes: 3,
    tags: ["news", "events"],
    date: Date()
  },
  {
    title: "Post Title 4",
    body: "Body of post.",
    category: "Event",
    likes: 4,
    tags: ["news", "events"],
    date: Date()
  }
])


// MongoDB mongosh Find

db.posts.find()

db.posts.findOne()

db.posts.find( {category: "News"} )

db.posts.find({}, {title: 1, date: 1})

db.posts.find({}, {_id: 0, title: 1, date: 1})

db.posts.find({}, {category: 0})


// MongoDB mongosh Update

db.posts.find( { title: "Post Title 1" } )

db.posts.updateOne( { title: "Post Title 1" }, { $set: { likes: 2 } } )

// If you would like to insert the document if it is not found, you can use the upsert option.
db.posts.updateOne( 
  { title: "Post Title 5" }, 
  {
    $set: 
      {
        title: "Post Title 5",
        body: "Body of post.",
        category: "Event",
        likes: 5,
        tags: ["news", "events"],
        date: Date()
      }
  }, 
  { upsert: true }
)

// Update likes on all documents by 1. For this we will use the $inc (increment) operator:
db.posts.updateMany({}, { $inc: { likes: 1 } })


// MongoDB mongosh Delete

db.posts.deleteOne({ title: "Post Title 5" })

db.posts.deleteMany({ category: "Technology" })
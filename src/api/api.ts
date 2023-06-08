// require('dotenv').config();

// const express = require("express");
// const path = require('path');
// const cookieParser = require("cookie-parser");
// const swaggerJsdoc = require("swagger-jsdoc");
// const swaggerUi = require("swagger-ui-express");

// const indexRouter = require("./routes/index.js");

// const app = express();
// const port = process.env.PORT || 3000

// app.use(express.json());
// app.use(express.urlencoded({ extended: false }));
// app.use(cookieParser());

// // ------ Configure swagger docs ------
// const options = {
//     swaggerDefinition: {
//       info: {
//         title: "My API",
//         version: "1.0.0",
//         description: "My API for doing cool stuff!",
//       },
//     },
//     apis: [path.join(__dirname, "/routes/*.js")],
//   };
// const swaggerSpecs = swaggerJsdoc(options);

// app.use("/api", indexRouter);
// app.use("/swagger", swaggerUi.serve, swaggerUi.setup(swaggerSpecs));

// app.listen(port, () => {
//     console.log(`Example app listening on port ${port}`)
// })

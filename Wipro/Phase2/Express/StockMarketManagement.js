const express = require("express");
const http = require("http");
const { Server } = require("socket.io");
const axios = require("axios");
const cors = require("cors");

const app = express();
const server = http.createServer(app);
const io = new Server(server, {
    cors: { origin: "http://localhost:3000", methods: ["GET", "POST"] }
});

app.use(cors());

// Fetch stock data (Replace with real API if needed)
const getStockData = async (symbol) => {
    try {
        const stockData = {
            symbol: symbol,
            price: (Math.random() * 1000).toFixed(2), // Simulated price
            change: (Math.random() * 10 - 5).toFixed(2), // Simulated price change
            time: new Date().toLocaleTimeString()
        };
        return stockData;
    } catch (error) {
        console.error("Error fetching stock data:", error);
        return null;
    }
};

io.on("connection", (socket) => {
    console.log("Client connected:", socket.id);

    socket.on("subscribeToStock", async (symbol) => {
        console.log(`Client subscribed to stock: ${symbol}`);

        const interval = setInterval(async () => {
            const stockData = await getStockData(symbol);
            if (stockData) {
                socket.emit("stockUpdate", stockData);
            }
        }, 5000); // Update every 5 seconds

        socket.on("disconnect", () => {
            console.log(`Client disconnected: ${socket.id}`);
            clearInterval(interval);
        });
    });
});

server.listen(4000, () => {
    console.log("Server running on port 4000");
});

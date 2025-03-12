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

// Fetch stock data from Alpha Vantage API
const getStockData = async (symbol) => {
    try {
        const response = await axios.get(`https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=${symbol}&apikey=1HPKQOBOA9GQY4E4`);
        
        const stockInfo = response.data["Global Quote"];
        
        if (!stockInfo) {
            throw new Error("Invalid API response");
        }

        return {
            symbol: stockInfo["01. symbol"],
            price: parseFloat(stockInfo["05. price"]).toFixed(2),
            change: parseFloat(stockInfo["09. change"]).toFixed(2),
            time: new Date().toLocaleTimeString()
        };
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

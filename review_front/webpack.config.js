const HtmlWebPackPlugin = require("html-webpack-plugin");

module.exports = {
    mode: "production",
    devtool: "source-map",
    module: {
        rules: [
            {
                test: /\.ts(x?)$/,
                exclude: /node_modules/,
                use: {
                    loader: "ts-loader"
                }
            },
            {
                test: /\.html$/,
                use: {
                        loader: "html-loader"
                }
            },
            {
                enforce: "pre",
                test: /\.js$/,
                loader: "source-map-loader"
            }
        ]
    },
    plugins: [
        new HtmlWebPackPlugin({
            template: "./src/index.html",
            filename: "./index.html"
        })
    ],
    resolve: {
        extensions: ['.js', '.jsx', '.tsx', '.ts']
    }
}; 
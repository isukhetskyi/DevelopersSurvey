﻿const path = require('path');
const webpack = require('webpack');
const ExtractTextPlugin = require("extract-text-webpack-plugin");
const { CheckerPlugin } = require('awesome-typescript-loader');

//const paths = {
//    outputDir: './wwwroot/dist'
//};

var Pahts = {
    outputDir: './wwwroot/dist'
};

const config = {
    entry: {
        homepage: './UI/Homepage/index.tsx',
        survey: './UI/Survey/index.tsx',
        statistics: './UI/Statistics/index.tsx',
        respondents: './UI/Respondents/index.tsx',
        libs: [
            'bootstrap',
            'bootstrap/dist/css/bootstrap.css',
            'react',
            'react-dom',
            'jquery'
        ]
    },
    output: {
        path: path.join(__dirname, Pahts.outputDir),
        filename: '[name].js',
        publicPath: '/dist/'
    },
    module: {
        rules: [
            {
                test: /\.(png|jpg|jpeg|gif|svg|woff|woff2|eot|ttf)$/,
                use: [
                    {
                        loader: 'url-loader',
                        options: {
                            limit: 50000,
                            name: 'assets/[name]_[hash].[ext]'
                        }
                    }
                ]
            },
            {
                test: /\.ts(x?)$/,
                exclude: /node_modules/,
                use: [
                    { loader: 'babel-loader' },
                    {
                        loader: 'awesome-typescript-loader',
                        options: {
                            silent: true
                        }
                    },
                ]
            },
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: [
                    { loader: 'babel-loader' }
                ]
            },
            {
                test: /\.(css|scss)$/,
                use: ExtractTextPlugin.extract({
                    fallback: 'style-loader',
                    use: ['css-loader', 'sass-loader']
                })
            }
        ]
    },
    plugins: [
        new CheckerPlugin(),
        new ExtractTextPlugin({
            filename: 'styles/[name].css',
            allChunks: true
        }),
        new webpack.ProvidePlugin({
            $: 'jquery',
            jQuery: 'jquery'
        }),
        new webpack.optimize.CommonsChunkPlugin({
            name: "commons",
            filename: "commons.js",
        }),
        new webpack.SourceMapDevToolPlugin({
            moduleFilenameTemplate: path.relative(Pahts.outputDir, '[resourcePath]')
        })
    ],
    resolve: { 
        extensions: [ '.js', '.jsx', '.ts', '.tsx' ] 
    }
};

module.exports = config;
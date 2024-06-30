import React from 'react'
import { useState } from 'react'
import './Random.css'
import axios from 'axios'
import { useEffect } from 'react'
import Spinner from './Spinner'

export const Random = () => {

    let API_KEY = process.env.REACT_APP_GIPHY_API_KEY 
    let [gif,setgif] = useState('')
    let [load,setload] = useState(false)

    
    async function fetchdata()
    {
        setload(true)
        let url =  `https://api.giphy.com/v1/gifs/random?api_key=${API_KEY}`;
        let {data} = await axios.get(url)
        // console.log(data)
        let src = data.data.images.downsized_large.url
        console.log(src)
        setgif(src)
        setload(false)
    }

    useEffect(() =>
    {
        fetchdata()
    },[])


    function ClickHandler()
    {
        fetchdata()
    }


   return (
    <div className='random'>
        
        <h1>Random GIF</h1>
        {
            load ? (<Spinner/>) : (<img src={gif} width={450} height={450} alt="" />)
        }
        <button onClick={ClickHandler}>Generate</button>
    </div>
  )
}

export default Random
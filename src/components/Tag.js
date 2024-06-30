import React from 'react'
import { useState } from 'react'
import './Random.css'
import axios from 'axios'
import { useEffect } from 'react'
import Spinner from './Spinner'
import './Tag.css'

export const Tag = () => {

    let API_KEY = process.env.REACT_APP_GIPHY_API_KEY 
    let [gif,setgif] = useState('')
    let [load,setload] = useState(false)
    let [tag,settag] = useState('')
    
    async function fetchdata()
    {
        setload(true)
        let url =  `https://api.giphy.com/v1/gifs/random?api_key=${API_KEY}&tag=${tag}`;
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


    function ChangeHandler(event)
    {
        settag(event.target.value)
    }

   return (
    
    <div className='random'> 
        <h1>Random GIF</h1>
        
        {
            load ? (<Spinner/>) : (<img src={gif} width={450} height={450} alt="" />)
        }

        <input type="text" placeholder='Meme' value={tag} onChange={ChangeHandler} />
        <button onClick={ClickHandler}>Generate</button>
    </div>
  )
}

export default Tag
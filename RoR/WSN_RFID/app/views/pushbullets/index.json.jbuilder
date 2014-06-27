json.array!(@pushbullets) do |pushbullet|
  json.extract! pushbullet, :id, :token, :email, :motivo
  json.url pushbullet_url(pushbullet, format: :json)
end

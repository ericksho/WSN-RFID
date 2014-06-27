class PushbulletsController < ApplicationController
  before_action :set_pushbullet, only: [:show, :edit, :update, :destroy]

  # GET /pushbullets
  # GET /pushbullets.json
  def index
    @pushbullets = Pushbullet.all
  end

  # GET /pushbullets/1
  # GET /pushbullets/1.json
  def show
  end

  # GET /pushbullets/new
  def new
    @pushbullet = Pushbullet.new
  end

  # GET /pushbullets/1/edit
  def edit
  end

  # POST /pushbullets
  # POST /pushbullets.json
  def create
    @pushbullet = Pushbullet.new(pushbullet_params)

    respond_to do |format|
      if @pushbullet.save
        format.html { redirect_to @pushbullet, notice: 'Pushbullet was successfully created.' }
        format.json { render :show, status: :created, location: @pushbullet }
      else
        format.html { render :new }
        format.json { render json: @pushbullet.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /pushbullets/1
  # PATCH/PUT /pushbullets/1.json
  def update
    respond_to do |format|
      if @pushbullet.update(pushbullet_params)
        format.html { redirect_to @pushbullet, notice: 'Pushbullet was successfully updated.' }
        format.json { render :show, status: :ok, location: @pushbullet }
      else
        format.html { render :edit }
        format.json { render json: @pushbullet.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /pushbullets/1
  # DELETE /pushbullets/1.json
  def destroy
    @pushbullet.destroy
    respond_to do |format|
      format.html { redirect_to pushbullets_url, notice: 'Pushbullet was successfully destroyed.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_pushbullet
      @pushbullet = Pushbullet.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def pushbullet_params
      params.require(:pushbullet).permit(:token, :email, :motivo)
    end
end
